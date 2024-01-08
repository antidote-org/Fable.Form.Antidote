namespace Fable.Form.Antidote.Field

open Fable.Form

module SwitchField =

    type Attributes =
        {
            Text : string
            Id : string
        }

    type SwitchField<'Values> = Field.Field<Attributes, bool, 'Values>

    let form<'Values, 'Field, 'Output> : ((SwitchField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, bool, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            (fun _ -> false)
