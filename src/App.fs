module App

open Elmish
open Elmish.React
open Fable.Helpers.React.Props

type Model = int

type Msg = Increment | Decrement

let init () =
  0

let update (msg:Msg) count =
  match msg with
  | Increment -> count + 1
  | Decrement -> count - 1

module R = Fable.Helpers.React

let view model dispatch =

  R.div []
      [ R.button [ OnClick (fun _ -> dispatch Decrement) ] [ R.str "-" ]
        R.div [] [ R.str (sprintf "%A" model) ]
        R.button [ OnClick (fun _ -> dispatch Increment) ] [ R.str "+" ] ]


Program.mkSimple init update view
|> Program.withReact "elmish-app"
|> Program.run
