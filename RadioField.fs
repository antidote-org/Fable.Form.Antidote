namespace Fable.Form.Antidote.Field

open Fable.Form

module RadioField =

    type Layout =
        | Horizontal
        | Vertical

    type Attributes =
        {
            Label : string
            Options : (string * string) list
            Layout : Layout
        }

    type RadioField<'Values> = Field.Field<Attributes, string, 'Values>

    let form<'Values, 'Field, 'Output> : ((RadioField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
