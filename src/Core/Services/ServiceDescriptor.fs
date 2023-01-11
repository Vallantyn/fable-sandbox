// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

module Services.Descriptor

open System

[<RequireQualifiedAccess>]
type ServiceLifetime =
| Singleton
| Transient
| Scoped

//[<DebuggerDisplay("Lifetime = {Lifetime}, ServiceType = {ServiceType}, ImplementationType = {ImplementationType}")>]
/// <summary>
/// Describes a service with its service type, implementation, and lifetime.
/// </summary>
type ServiceDescriptor (serviceType:Type, lifetime:ServiceLifetime) =
    let _ServiceType = serviceType
    let _Lifetime = lifetime

    /// <summary>
    /// Initializes a new instance of <see cref="ServiceDescriptor"/> with the specified <paramref name="implementationType"/>.
    /// </summary>
    /// <param name="serviceType">The <see cref="Type"/> of the service.</param>
    /// <param name="implementationType">The <see cref="Type"/> implementing the service.</param>
    /// <param name="lifetime">The <see cref="ServiceLifetime"/> of the service.</param>
    new (serviceType:Type, implementationType:Type, lifetime:ServiceLifetime) =
        // ImplementationType = implementationType;
        ServiceDescriptor (serviceType, lifetime)

    /// <summary>
    /// Initializes a new instance of <see cref="ServiceDescriptor"/> with the specified <paramref name="instance"/>
    /// as a <see cref="ServiceLifetime.Singleton"/>.
    /// </summary>
    /// <param name="serviceType">The <see cref="Type"/> of the service.</param>
    /// <param name="instance">The instance implementing the service.</param>
    new (serviceType: Type, instance: obj) =
        // ImplementationInstance = instance;
        ServiceDescriptor (serviceType, ServiceLifetime.Singleton)

    /// <summary>
    /// Initializes a new instance of <see cref="ServiceDescriptor"/> with the specified <paramref name="factory"/>.
    /// </summary>
    /// <param name="serviceType">The <see cref="Type"/> of the service.</param>
    /// <param name="factory">A factory used for creating service instances.</param>
    /// <param name="lifetime">The <see cref="ServiceLifetime"/> of the service.</param>
    new (serviceType:Type, factory:(IServiceProvider -> obj), lifetime:ServiceLifetime) =
        // ImplementationFactory = factory;
        ServiceDescriptor (serviceType, lifetime)

    // private ServiceDescriptor(Type serviceType, ServiceLifetime lifetime)
    // {
    //     Lifetime = lifetime;
    //     ServiceType = serviceType;
    // }

    /// <summary>
    /// Gets the <see cref="ServiceLifetime"/> of the service.
    /// </summary>
    member _.Lifetime = _Lifetime

    /// <summary>
    /// Gets the <see cref="Type"/> of the service.
    /// </summary>
    member _.ServiceType = _ServiceType

    /// <summary>
    /// Gets the factory used for creating service instances.
    /// </summary>
    member _.ImplementationFactory:(IServiceProvider -> obj) option = None

    /// <inheritdoc />
    override My.ToString() =
        let lifetime = $"{nameof(My.ServiceType)}: {My.ServiceType} {nameof(My.Lifetime)}: {My.Lifetime} "
        
        // if My.ImplementationType.IsSome then
        //     lifetime + $"{nameof(My.ImplementationType)}: {My.ImplementationType}"
        if My.ImplementationFactory.IsSome then
            lifetime + $"{nameof(My.ImplementationFactory)}: {{My.ImplementationFactory}}"
        else lifetime
        // else lifetime + $"{nameof(My.ImplementationInstance)}: {My.ImplementationInstance}"

    member internal My.GetImplementationType() =
        // if My.ImplementationType.IsSome then
        //     My.ImplementationType.Value
        // elif My.ImplementationInstance.IsSome then
        //     My.ImplementationInstance.Value.GetType()
        typeof<obj>
        // {
        //     Type[]? typeArguments = ImplementationFactory.GetType().GenericTypeArguments;

        //     Debug.Assert(typeArguments.Length == 2);

        //     return typeArguments[1];
        // }

        // Debug.Assert(false, "ImplementationType, ImplementationInstance or ImplementationFactory must be non null");
        // return null;

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <typeparamref name="TService"/>, <paramref name="implementationFactory"/>,
    /// and the <see cref="ServiceLifetime.Transient"/> lifetime.
    /// </summary>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member inline Transient<'Service when 'Service: not struct> (implementationFactory:(IServiceProvider -> obj)) =
        // ThrowHelper.ThrowIfNull(implementationFactory);
        ServiceDescriptor.Describe (typeof<'Service>, implementationFactory, ServiceLifetime.Transient)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <paramref name="service"/>, <paramref name="implementationFactory"/>,
    /// and the <see cref="ServiceLifetime.Transient"/> lifetime.
    /// </summary>
    /// <param name="service">The type of the service.</param>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member Transient(service:Type, implementationFactory:(IServiceProvider -> obj)) =
        // ThrowHelper.ThrowIfNull(service);
        // ThrowHelper.ThrowIfNull(implementationFactory);
        ServiceDescriptor.Describe (service, implementationFactory, ServiceLifetime.Transient)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <typeparamref name="TService"/>, <paramref name="implementationFactory"/>,
    /// and the <see cref="ServiceLifetime.Scoped"/> lifetime.
    /// </summary>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member inline Scoped<'Service when 'Service: not struct> (implementationFactory:(IServiceProvider -> obj)) =
        // ThrowHelper.ThrowIfNull(implementationFactory);
        ServiceDescriptor.Describe (typeof<'Service>, implementationFactory, ServiceLifetime.Scoped)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <paramref name="service"/>, <paramref name="implementationFactory"/>,
    /// and the <see cref="ServiceLifetime.Scoped"/> lifetime.
    /// </summary>
    /// <param name="service">The type of the service.</param>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member Scoped(service:Type, implementationFactory:(IServiceProvider -> obj)) =
        // ThrowHelper.ThrowIfNull(service);
        // ThrowHelper.ThrowIfNull(implementationFactory);
        ServiceDescriptor.Describe (service, implementationFactory, ServiceLifetime.Scoped)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <typeparamref name="TService"/>, <paramref name="implementationFactory"/>,
    /// and the <see cref="ServiceLifetime.Singleton"/> lifetime.
    /// </summary>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member inline Singleton<'Service when 'Service: not struct> (implementationFactory:(IServiceProvider -> obj)):ServiceDescriptor =
        // ThrowHelper.ThrowIfNull(implementationFactory);
        ServiceDescriptor.Describe (typeof<'Service>, implementationFactory, ServiceLifetime.Singleton)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <paramref name="serviceType"/>, <paramref name="implementationFactory"/>,
    /// and the <see cref="ServiceLifetime.Singleton"/> lifetime.
    /// </summary>
    /// <param name="serviceType">The type of the service.</param>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member Singleton (serviceType:Type, implementationFactory:(IServiceProvider -> obj)):ServiceDescriptor =
        // ThrowHelper.ThrowIfNull(serviceType);
        // ThrowHelper.ThrowIfNull(implementationFactory);
        ServiceDescriptor.Describe (serviceType, implementationFactory, ServiceLifetime.Singleton)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <typeparamref name="TService"/>, <paramref name="implementationInstance"/>,
    /// and the <see cref="ServiceLifetime.Singleton"/> lifetime.
    /// </summary>
    /// <typeparam name="TService">The type of the service.</typeparam>
    /// <param name="implementationInstance">The instance of the implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member inline Singleton<'Service when 'Service: not struct> (implementationInstance:'Service):ServiceDescriptor =
        // ThrowHelper.ThrowIfNull(implementationInstance);
        ServiceDescriptor.Singleton (typeof<'Service>, implementationInstance)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <paramref name="serviceType"/>, <paramref name="implementationInstance"/>,
    /// and the <see cref="ServiceLifetime.Singleton"/> lifetime.
    /// </summary>
    /// <param name="serviceType">The type of the service.</param>
    /// <param name="implementationInstance">The instance of the implementation.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member Singleton(
        serviceType: Type,
        implementationInstance: obj
    ): ServiceDescriptor =
        // ThrowHelper.ThrowIfNull(serviceType);
        // ThrowHelper.ThrowIfNull(implementationInstance);
        ServiceDescriptor(serviceType, implementationInstance)

    /// <summary>
    /// Creates an instance of <see cref="ServiceDescriptor"/> with the specified
    /// <paramref name="serviceType"/>, <paramref name="implementationFactory"/>,
    /// and <paramref name="lifetime"/>.
    /// </summary>
    /// <param name="serviceType">The type of the service.</param>
    /// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
    /// <param name="lifetime">The lifetime of the service.</param>
    /// <returns>A new instance of <see cref="ServiceDescriptor"/>.</returns>
    static member Describe(
        serviceType: Type,
        implementationFactory: (IServiceProvider -> obj),
        lifetime: ServiceLifetime
    ): ServiceDescriptor =
        ServiceDescriptor(serviceType, implementationFactory, lifetime)
