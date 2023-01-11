module Services.ICollection

open System.Collections.Generic
open Services.Descriptor

type IServiceCollection =
    inherit IList<ServiceDescriptor>