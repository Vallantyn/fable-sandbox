namespace Platforms.WebGL

open Systems.Renderer

open WebGL.Types

type ActiveInfo (activeInfo:WebGLActiveInfo option) =
    let _data:WebGLActiveInfo option = activeInfo

    new () = ActiveInfo None

    interface IActiveInfo with
        member _.Try () =
            _data
            |> Option.map (fun i -> i)

        member _.Name =
            _data
            |> Option.map (fun i -> i.name)
            |> Option.defaultValue ""

        member _.Size =
            _data
            |> Option.map (fun i -> i.size)
            |> Option.defaultValue -1

        member _.Type =
            _data
            |> Option.map (fun i -> i.``type``)
            |> Option.defaultValue 1u
