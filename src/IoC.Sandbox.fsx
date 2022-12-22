#r "nuget: GoblinFactory.Konsole"
#r "nuget: GEmojiSharp"

open System
open System.Reflection

open GEmojiSharp

let mutable indent = 0

let WriteIndent _ = Console.Write("|   ")

let LogColor (msg:string) (color:ConsoleColor) =
    let fg = Console.ForegroundColor
    Console.ForegroundColor <- color

    if indent > 0 then
        [0..indent-1]
        |> List.iter WriteIndent

    Console.Write(msg.Emojify())
    Console.WriteLine()

    Console.ForegroundColor <- fg

let BreakLineWithIndent () =
    LogColor "" ConsoleColor.DarkGray

let LogInfo (msg:string) =
    LogColor msg ConsoleColor.Cyan

let LogWarning (msg:string) =
    LogColor msg ConsoleColor.Yellow

let LogError (msg:string) =
    LogColor msg ConsoleColor.Red

let Log (msg:string) =
    LogColor msg ConsoleColor.Gray

let IndentPush () = indent <- indent + 1
let IndentPop () = indent <- max 0 indent - 1

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

type ServiceD (a:ServiceA, b:ServiceB) =
    let _A = a
    let _B = b
    
    new (a:ServiceA) =
        ServiceD(a, ServiceB())
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

(*
** for each service
** list dependency
** foreach dependency
** list dependency
** ...
** until dependency without one
*)

(*
    Type { Constructors Constructor[] }
    |- Constructor { Parameters Type[] }

    Type {
        Constructors {
            Parameters {
                Type ...
            }
        }
    }
    
    Type T
    |- Constructors[]
        |- Constructor T | Parameters T[]
    
*)

RegisterService<ServiceA>()
RegisterService<ServiceB>()

RegisterService<ServiceC>()
RegisterService<ServiceD>()

"BEGIN" |> LogInfo
"Services Without Dependencies:" |> LogInfo
for serviceType in ListServices_WithoutDependencies() do
    Log $"- {serviceType}"

Console.WriteLine()

"Services With Dependencies:" |> LogInfo
for serviceType in ListServices_WithDependencies() do
    Log $"- {serviceType}"

Console.WriteLine()

for service in RegisteredServices do
    ListConstructors service
    match service |> TryConstructDefault with
    | None -> LogWarning $"Could not construct default for {service.Name}"
    | Some o -> LogColor $"Built {o}" ConsoleColor.Green
    // let t = ConstructDefault service
    // printfn $"{t}"

Console.WriteLine()
"Dependencies:" |> LogInfo

(*
    RULES:
    
    v1
    - a type declares its dependencies in its constructor
    - a type can have an empty constructor
        -> No dependency
    - a type can have multiple constructor
        - in that case each ctor is resolved
        - if a dependenct cannot be found, the ctor is ommitted
        - the resolved ctor with the most dependencies is used
        - if there's an ambiguity -> THROW
        - if there's an ambiguity AND an INDEPENDANT ctor -> use the empty one
    
    v2
    - Let's try and deal with cyclic dependencies...
*)

type TConstructor = 
    | Parameters of TType[]
    | Empty of Type:Type

    static member CreateFromConstructorInfo (inCtor:Reflection.ConstructorInfo) =
        match inCtor.GetParameters() with
        | parameters when not (parameters |> Array.isEmpty)
            -> parameters
                |> Array.map (fun p -> p.ParameterType |> TType.CreateFromType)
                |> Parameters
        | _ -> Empty inCtor.DeclaringType

    override My.ToString () =
        match My with
        | Empty t -> "_"
        | Parameters parameters ->
            parameters
            |> Array.map (fun p -> p.ToString())
            |> String.concat ", "
            |> sprintf "(%s)"

and TType =
    | Constructors of Type:Type * Ls:TConstructor[]

    static member CreateFromType (inType:Type) =
        let ctors = 
            inType.GetConstructors()
            |> Array.map TConstructor.CreateFromConstructorInfo
        Constructors (inType, ctors)

    override My.ToString () =
        match My with
        | Constructors (t, ctors) ->
            if ctors |> Array.isEmpty then t.Name
            else
                let header = $"{t.Name}:\n"
            // for ctor in ctors do
            //     header
                ctors
                |> Array.fold (fun a b -> a + $"\t{b}\n") header
            // |> Array.map (fun c -> c.ToString())
            // |> String.concat "\n"
            // |> sprintf "%s {\n\t%s\n}" t.Name

let Type_GetConstructors (inType:Type) =
    match inType.GetConstructors() with
    | ctors when
        ctors
        |> Array.isEmpty
        |> not
        -> Some ctors
    | _ -> None

let Constructor_GetParameters (inCtor:Reflection.ConstructorInfo) =
    match inCtor.GetParameters() with
    | parameters 
        when parameters
        |> Array.isEmpty
        |> not
        -> Some parameters
    | _ -> None


let GetTypeConstructors (t:Type) =
    // IndentPush()
    Log $"Getting Constructors for Type: {t.Name}..."

    let result =
        t.GetConstructors()
        |> Array.map (
            fun c ->
            c.GetParameters()
            |> Array.map (fun p -> p.ParameterType)
        )
    // IndentPop()

    result

open Konsole

let rec ResolveConstructor (c:Type[]) =
    LogColor $"""Resolving Constructor: ({c |> Array.map (fun t -> t.Name) |> String.concat ", "})...""" ConsoleColor.DarkGray

    IndentPush()
    let result = c |> Array.forall ResolveType
    IndentPop()

    result

and ResolveType (t:Type) =

    let ctors = t |> GetTypeConstructors

    let pb = ProgressBar(ctors.Length)

    IndentPush()
    let result = 
        ctors
        |> Array.forall (fun c -> 
            System.Threading.Thread.Sleep(1000)
            pb.Refresh(1, $"Resolving Type: {t.Name}...")
            c |> ResolveConstructor
        )
    IndentPop()
    BreakLineWithIndent()
    System.Threading.Thread.Sleep(1000)
    result

// let test:Type = Type.GetType("")

// test
// |> ResolveType


let ResolveConstructor' (c:ConstructorInfo) =
    false

let GetConstructorsMaps (t:Type) =
    t.GetConstructors()
    |> Array.mapi (
        fun i c ->
        (i, c.GetParameters()
        |> Array.map (fun p -> p.ParameterType))
    )
    |> Map.ofArray

(*

Type -> {i:Type[]}
Type -> Type[][]

*)

let rec getTypeDependency (inType:Type) =
    // let depth = defaultArg depth 0
    LogInfo $"{inType.Name}"
    let typeConstructors = 
        inType
        |> GetConstructors

    for typeConstructor in typeConstructors do
        let callback = typeConstructor.Callback;
        LogInfo $"|- {callback.Name}"
        let parameters = callback.GetParameters();
        for parameter in parameters do
            LogInfo $"  |- {parameter.Name}:{parameter.ParameterType.Name}"
            parameter.ParameterType 
            |> getTypeDependency

    Console.WriteLine()

//  foreach Constructors
//      try and resolve
//          -> recurse resolve for each dependency
//          TODO: catch cyclic dependency as unresolvable
//          OK      add to resolved stack
//          NOPE    continue
//  filter resolved ctors
//      remove same size
//      keep highest
//  if there's anything left    OK
//  else                        THROW
    
for service in RegisteredServices do
    service
    |> TType.CreateFromType
    |> string
    |> LogInfo

    Console.WriteLine()

"#####\n" |> LogWarning

RegisteredServices
|> List.iter (
    fun t ->
        LogColor "------------------------------------------------------------" ConsoleColor.DarkGray
        if t |> ResolveType then LogColor $"Resolved :slightly_smiling_face:" ConsoleColor.Green
        else LogError $"Unresolved :frowning_face:"
        BreakLineWithIndent ()
)

"/ END\n" |> LogInfo
