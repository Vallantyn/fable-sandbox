open System

let LogColor (msg:string) (color:ConsoleColor) =
    let fg = Console.ForegroundColor
    Console.ForegroundColor <- color
    Console.WriteLine(msg)
    Console.ForegroundColor <- fg

let LogInfo (msg:string) =
    LogColor msg ConsoleColor.Cyan

let LogWarning (msg:string) =
    LogColor msg ConsoleColor.Yellow

let LogError (msg:string) =
    LogColor msg ConsoleColor.Red

let Log (msg:string) =
    LogColor msg ConsoleColor.Gray

let BreakLine () =
    Console.Write '\n'

let mutable RegisteredServices:Type list = []

let RegisterService<'Service> () =
    let typeOfService = typeof<'Service>

    if not (RegisteredServices |> List.contains typeOfService)
    then RegisteredServices <- typeOfService :: RegisteredServices

// type Constructor = { Callback:Reflection.ConstructorInfo }
type Constructor = { Callback:Reflection.ConstructorInfo; Parameters:Type[]; }
type Constructor with
    member My.ConstructDefault () = My.Callback.Invoke[||]
    member My.Construct (parameters:obj[] option) =
        match parameters with
        | None -> My.ConstructDefault()
        | Some p -> My.Callback.Invoke p

let GetParameterTypes (parameters:Reflection.ParameterInfo[]) =
    parameters
    |> Array.map (fun p -> p.ParameterType)

let GetConstructor (parameters:Type[] option) (t:Type) =
    let parameterList =
        match parameters with
        | None -> [||]
        | Some p -> p

    match t.GetConstructor(parameterList) with
    | null -> None
    | ctor -> Some { Callback = ctor; Parameters = parameterList }

let GetConstructors (t:Type) =
    t.GetConstructors()
    |> Array.map (fun ctor -> { Callback = ctor; Parameters = ctor.GetParameters() |> GetParameterTypes })

let TryConstructDefault (t:Type) =
    match (t |> GetConstructor None) with
    | None -> None
    | Some tCtor -> Some(tCtor.ConstructDefault())

let GetTypes (objects:obj[] option) =
    match objects with
    | None -> [||]
    | Some object ->
        object
        |> Array.map (fun o -> o.GetType())

let TryConstructWith (t:Type) (parameters:obj[] option) =
    match t |> GetConstructor (parameters |> GetTypes |> Some) with
    | None -> None
    | Some ctor -> ctor.Construct(parameters) |> Some

    // match parameters with
    // | None -> TryConstructDefault t
    // | Some parameterList ->
    //     match t.GetConstructor (parameterList |> GetTypes) with
    //     | null -> None
    //     | tCtor -> Some(tCtor.Invoke parameterList)

let ConstructDefault (t:Type) =
    t.GetConstructor([||])
     .Invoke([||])

let ConstructDefault'<'T> =
    ConstructDefault typeof<'T>
    // typeof<'T>.GetConstructor([||])
    //           .Invoke([||])
    :?> 'T

(***********************************************************************************************************************
** Execution                                                                                                          **
***********************************************************************************************************************)

type ServiceA () =
    override _.ToString () = "Service AH!"

type ServiceB () =
    override _.ToString () = "Service Bae :3"

type ServiceC (a:ServiceA) =
    let _A = a
    override _.ToString () = $"Service Say: {_A}"

type ServiceD (b:ServiceB) =
    let _B = b
    override _.ToString () = $"Service Dit: {_B}"


let ListConstructors (t:Type) =
    Log $"{t}"
    for constructor in t.GetConstructors () do
    Log $"|-- {constructor}"
    for parameter in constructor.GetParameters () do
        Log $"|   |-- {parameter}"

let ListServices_WithoutDependencies () =
    RegisteredServices
    |> List.filter (fun serviceType -> (
        (serviceType
         |> GetConstructor None
         ).IsSome
    ))
    |> List.toArray

let ListServices_WithDependencies () =
    RegisteredServices
    |> List.filter (fun serviceType -> (
        serviceType
        |> GetConstructors
        |> Array.exists (fun ctor -> (
            ctor.Parameters
            |> Array.isEmpty
            |> not
        ))
    ))
    |> List.toArray

// TODO: List Services With Dependency Tree

RegisterService<ServiceA>()
RegisterService<ServiceB>()

RegisterService<ServiceC>()
RegisterService<ServiceD>()

"BEGIN" |> LogInfo
"Services Without Dependencies:" |> LogInfo
for serviceType in ListServices_WithoutDependencies() do
    Log $"- {serviceType}"

BreakLine()

"Services With Dependencies:" |> LogInfo
for serviceType in ListServices_WithDependencies() do
    Log $"- {serviceType}"

BreakLine()

for service in RegisteredServices do
    ListConstructors service
    match service |> TryConstructDefault with
    | None -> LogWarning $"Could not construct default for {service.Name}"
    | Some o -> LogColor $"Built {o}" ConsoleColor.Green
    // let t = ConstructDefault service
    // printfn $"{t}"
"/ END\n" |> LogInfo
