module Services.Collection

open System
open Services.ICollection
open Services.Descriptor

open System.Runtime.CompilerServices

[<Extension>]
type IServiceCollectionExtension () =
    
    [<Extension>]
    static member RegisterSingleton(
        services,
        serviceType,
        factory
    ) =
        IServiceCollectionExtension.Add (services, serviceType, factory, ServiceLifetime.Singleton)
    
    [<Extension>]
    static member inline RegisterSingleton<'Service>(
        services,
        factory
    ) =
        services.RegisterSingleton (typeof<'Service>, factory)
    
    [<Extension>]
    static member RegisterTransient(
        services,
        serviceType,
        factory
    ) =
        IServiceCollectionExtension.Add (services, serviceType, factory, ServiceLifetime.Transient)
    
    [<Extension>]
    static member inline RegisterTransient<'Service>(
        services,
        factory
    ) =
        services.RegisterTransient (typeof<'Service>, factory)

    static member private Add(
        collection: IServiceCollection,
        serviceType: Type,
        implementationFactory: (IServiceProvider -> obj),
        lifetime: ServiceLifetime
    ) =
        collection.Add (ServiceDescriptor (serviceType, implementationFactory, lifetime))
        collection
