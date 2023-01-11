#r "nuget: GoblinFactory.Konsole"
#r "nuget: Pastel"
#r "nuget: GEmojiSharp"

(* ─│┌┬┐├┼┤└┴┘ *)
module Log =
    open System
    open type Console
    open Pastel
    open GEmojiSharp


    let mutable indent = 0
    let WriteIndent _ = Write("│   ")

    let Separator () =
        WriteLine (
            String('─', WindowWidth)
                .Pastel(ConsoleColor.DarkGray)
        )

    let LogColor (msg:string) =
        if indent > 0 then
            [0..indent-1]
            |> List.iter WriteIndent

        WriteLine(msg.Emojify())

    let BreakLineWithIndent () =
        LogColor ("".Pastel "FFFFFF")

    let Info (msg:string) :unit =
        LogColor ($"{msg}".Pastel "009999")

    let Warn (msg:string) =
        LogColor ($"{msg}".Pastel "999900")

    let Error (msg:string) =
        LogColor ($"{msg}".Pastel "990000")

    let Msg (msg:string) =
        LogColor (msg.Pastel "CCCCCC")

    let IndentPush () = indent <- indent + 1
    let IndentPop () = indent <- max 0 indent - 1

module Services =
    open System 
    
    let mutable RegisteredServices:Type list = []
    let RegisterService<'Service> () =
        let typeOfService = typeof<'Service>

        if not (RegisteredServices |> List.contains typeOfService)
        then RegisteredServices <- typeOfService :: RegisteredServices

    type IService =
        abstract member GetName: string
        abstract member GetDependencies: string[]
        abstract member Construct: IService[] -> IService
        
    

(***********************************************************************************************************************
** Execution                                                                                                          **
***********************************************************************************************************************)

open System
open Pastel

type ServiceA () =
    override _.ToString () = "Service AH!"

type ServiceB () =
    override _.ToString () = "Service Bae :3"

type ServiceC (a:ServiceA) =
    member _.A = a
    override My.ToString () = $"Service Say: {My.A}"

type ServiceD (c:ServiceC, b:ServiceB) =
    let _C = c
    let _B = b
    
    new (a:ServiceA, b:ServiceB) =
        ServiceD(ServiceC(a), b)
    override _.ToString () = $"Service Dit: {_C} & {_B}"

Services.RegisterService<ServiceA>()
Services.RegisterService<ServiceB>()

Services.RegisterService<ServiceC>()
Services.RegisterService<ServiceD>()

"BEGIN" |> Log.Info

let sep = String('#', Console.WindowWidth) + "\n"

let inline good (str:string) = str.Pastel("00CC00")
let inline bad (str:string) = str.Pastel("CC0000")
let inline noun (typ:Type) = $"""<{typ.Name.Pastel("CC00CC")}>"""
let inline nount<'T> () = noun (typeof<'T>)

let mutable ServiceInstances = List.empty<obj>

type Constructor = Reflection.ConstructorInfo
type Constructors = Constructor[]
type MaybeConstructor = Constructor option

let TryResolveConstructors<'T> (constructors:Constructors):MaybeConstructor =
    constructors
    |> Array.toSeq
    |> Seq.sortWith (fun c1 c2 ->
        compare (c2.GetParameters().Length) (c1.GetParameters().Length)
    )
    |> Seq.toArray
    |> Array.tryFind (fun c ->
        c.GetParameters()
        |> Array.forall (
            fun p ->
                Services.RegisteredServices
                |> List.contains p.ParameterType
        )
    )

let rec TryGetService (serviceType:Type) =
    Log.Msg $"""Trying to {good "get"} Service {noun serviceType}..."""
    match ServiceInstances |> List.tryFind (fun t -> t.GetType() = serviceType ) with
    | Some t -> Some(t)
    | None -> 
        Log.Warn $"""Couldn't {bad "find"} Service {noun serviceType}, trying to {good "create"} it.."""
        TryCreateService serviceType

and TryCreateService (serviceType) =
    Log.Msg $"""Trying to {good "create"} Service {noun serviceType}..."""
    let ctors = serviceType.GetConstructors()
    let ctor =
        if ctors |> Array.isEmpty then None
        elif ctors.Length > 1 then
            Log.Warn $"""{noun serviceType} {good "has"} {ctors.Length} constructors, trying to resolve..."""
            TryResolveConstructors ctors
        else Some ctors[0]

    match ctor with
    | Some c -> TryConstruct c
    | None ->
        Log.Error $"""{noun serviceType} {bad "doesn't have"} any usable constructor, {bad "aborting"}..."""
        None

and TryConstruct (constructor:Constructor) =
    Log.Msg $"""Trying to {good "construst"} Service {noun constructor.DeclaringType}..."""
    let parameters = constructor.GetParameters()
    if parameters |> Array.isEmpty then
        let instance = constructor.Invoke [||]
        ServiceInstances <- instance::ServiceInstances
        Some instance
    else
        let resolvedParameters = 
            parameters
            |> Array.choose (fun p -> TryGetService(p.ParameterType))
        if resolvedParameters.Length <> parameters.Length then
            Log.Error $"""{bad "Couldn't resolve"} parameters for constructor, {bad "aborting"}..."""
            None
        else
            let instance = constructor.Invoke resolvedParameters
            ServiceInstances <- instance::ServiceInstances
            Some instance

let TryCreateServiceT<'T> () =
    TryCreateService (typeof<'T>)

let TryGetServiceT<'T> ():'T option =
    match TryGetService typeof<'T> with
    | Some s -> Some (s :?> 'T)
    | None -> None

match TryGetServiceT<ServiceD>() with
| Some a -> Log.Info $"""{good "Got"} our Service :slightly_smiling_face:: {a}"""
| None -> Log.Error $"""Couldn' t {bad "get"} our service {nount<ServiceC>()} :frowning_face:"""

Console.WriteLine()
"/ END\n" |> Log.Info
