module Services

open Services.ICollection
open Services.Collection

type Type = System.Type
type Constructor = System.Reflection.ConstructorInfo
type Constructors = Constructor[]
type MaybeConstructor = Constructor option

type ServiceDeclaration =
| Abstract of Interface:System.Type * Implementation:System.Type
| Concrete of System.Type

type ServiceInstance =
| Abstract of Interface:System.Type * Implementation:obj
| Concrete of obj

(*
    Host.CreateDefaultBuilder(args)
        .ConfigureServices(
            (_, services) =>
            services
                .AddTransient<TransientDisposable>()
                .AddScoped<ScopedDisposable>()
                .AddSingleton<SingletonDisposable>()
        )
        .Build();
    
    Host -> App
    HostBuilder -> App's Config
        ConfigServices ("ServiceCollection" -> ()) => uses servcol to define services
        Build => Exec routine defined above
    callback: IServiceProvider (get dependencies) -> obj (service instance)
*)


type ServiceProvider () =
    interface System.IServiceProvider with
        member My.GetService (serviceType: Type) =
            ""

open System.Collections
open System.Collections.Generic
open Services.Descriptor

type ServiceCollection () =
    let _Services = ResizeArray<ServiceDescriptor>()
    
    interface IServiceCollection with
        member _.Add (item) = _Services.Add item
        member _.Clear () = _Services.Clear ()
        member _.Contains(item: ServiceDescriptor) = _Services.Contains item

        member _.CopyTo (array: ServiceDescriptor[], arrayIndex: int): unit = _Services.CopyTo (array, arrayIndex)

        member _.Count = _Services.Count
        member _.GetEnumerator(): IEnumerator = _Services.GetEnumerator ()
        member _.GetEnumerator (): IEnumerator<ServiceDescriptor> = _Services.GetEnumerator ()
        member _.IndexOf (item: ServiceDescriptor) = _Services.IndexOf item
        member _.Insert (index: int, item: ServiceDescriptor): unit = _Services.Insert (index, item)
        member _.IsReadOnly: bool = false

        member _.Item
            with get (index: int): ServiceDescriptor = _Services.Item(index)
            and set (index: int) (v: ServiceDescriptor): unit = _Services.Item(index) <- v
                
        member _.Remove(item: ServiceDescriptor): bool = _Services.Remove item
        member _.RemoveAt(index: int): unit = _Services.RemoveAt index

type IHostBuilder =
    abstract member ConfigureServices: (IServiceCollection -> unit) -> IHostBuilder
    abstract member Build: unit -> unit

type DefaultHostBuilder (serviceCollection) =
    let _ServiceCollection:IServiceCollection = serviceCollection 
    let mutable _Callback = (fun _ -> ())

    interface IHostBuilder with
        member My.ConfigureServices callback =
            _Callback <- callback
            My

        member My.Build () =
            _Callback _ServiceCollection

type IHost =
    abstract member GetDefaultBuilder: unit -> IHostBuilder

type Host () =
    let serviceCollection = ServiceCollection()
    let defaultHostBuilder = lazy DefaultHostBuilder(serviceCollection)

    interface IHost with
        member _.GetDefaultBuilder() =
            defaultHostBuilder.Value
            
    static member CreateDefaultBuilder () :IHostBuilder =
        DefaultHostBuilder (ServiceCollection ())

type ServiceManager () =
    // let ServiceInstances = ResizeArray<ServiceInstance>()
    // let RegisteredServices = ResizeArray<ServiceDeclaration>()//List.empty<ServiceDeclaration>

    let Transients = ResizeArray<{| Type:Type; Callback:(unit -> obj) |}>()//List.empty<ServiceDeclaration>
    let Singletons = ResizeArray<{| Type:Type; Callback:(unit -> obj) |}>()//List.empty<ServiceDeclaration>

    let Services = ResizeArray<{| Type:Type; Instance:obj |}>()

    // member private My.HasRegisteredService (serviceType:Type) =
    //     RegisteredServices.ToArray()
    //         |> Array.tryFind (fun service ->
    //             match service with
    //             | ServiceDeclaration.Abstract (i, t) -> i = serviceType || t = serviceType
    //             | ServiceDeclaration.Concrete c -> c = serviceType
    //         )
    //         |> Option.isSome

    // member inline private My.RegisterService_Internal<'I, 'T> () =
    //     if not (My.HasRegisteredService typeof<'I>)
    //     then if typeof<'I> <> typeof<'T> then RegisteredServices.Add(ServiceDeclaration.Abstract(typeof<'I>, typeof<'T>))
    //     else RegisteredServices.Add(ServiceDeclaration.Concrete typeof<'T>)

    // member inline My.RegisterService<'I, 'T> () =
    //     My.RegisterService_Internal<'I, 'T> ()

    // member inline My.RegisterService<'T> () =
    //     My.RegisterService_Internal<'T, 'T> ()

    // member inline private My.TryResolveConstructors<'T> (constructors:Constructors) =
    //     constructors
    //     |> Array.toSeq
    //     |> Seq.sortWith (fun c1 c2 ->
    //         compare (c2.GetParameters().Length) (c1.GetParameters().Length)
    //     )
    //     |> Seq.toArray
    //     |> Array.tryFind (fun c ->
    //         c.GetParameters()
    //         |> Array.forall (
    //             fun p ->
    //             (My.HasRegisteredService p.ParameterType)
    //         )
    //     )

    // member private My.TryConstruct (constructor:Constructor) =
    //     let parameters = constructor.GetParameters()
    //     if parameters |> Array.isEmpty then
    //         let instance = constructor.Invoke [||]
    //         ServiceInstances.Add(Concrete instance)
    //         Some instance
    //     else
    //         let resolvedParameters = 
    //             parameters
    //             |> Array.choose (fun p -> My.TryGetService_Internal(p.ParameterType))
    //         if resolvedParameters.Length <> parameters.Length then
    //             None
    //         else
    //             let instance = constructor.Invoke resolvedParameters
    //             ServiceInstances.Add(Concrete instance)
    //             Some instance

    // member private My.TryCreateService (serviceType:Type) =
    //     let ctors = serviceType.GetConstructors()
    //     let ctor =
    //         if ctors |> Array.isEmpty then None
    //         elif ctors.Length > 1 then
    //             My.TryResolveConstructors ctors
    //         else Some ctors[0]

    //     match ctor with
    //     | Some c -> My.TryConstruct c
    //     | None ->
    //         None
    
    // member private My.TryGetService_Internal (serviceType:Type) =
    //     match ServiceInstances.ToArray()
    //         |> Array.tryFind (fun service ->
    //             match service with
    //             | Abstract (i, _) -> i = serviceType
    //             | Concrete c -> c.GetType() = serviceType
    //         ) with
    //     | Some t -> Some(t)
    //     | None -> 
    //         My.TryCreateService serviceType

    // member inline My.TryGetService<'I> () =
    //     My.TryGetService_Internal typeof<'I>

    member inline My.RegisterSingleton<'I> callback =
        Singletons.Add {|
            Type     = typeof<'I>
            Callback = callback
        |}

    member My.Build() =
        for singleton in Singletons do
            Services.Add {|
                Type = singleton.Type
                Instance = singleton.Callback()
            |}

    member inline My.GetService<'I> () =
        Services.ToArray()
        |> Array.tryFind (fun service -> service.Type = typeof<'I>)
        |> Option.map (fun service -> service.Instance :?> 'I)
