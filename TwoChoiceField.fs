namespace Fable.Form.Antidote.Field

open Fable.Form

module TwoChoiceField =

    type Attributes = {
        Id: string
        Label: string
        Options1: (string * string)
        Options2: (string * string)
    }

    type TwoChoiceField<'Values> = Field.Field<Attributes, string, 'Values>

    let form<'Values, 'Field, 'Output> : ((TwoChoiceField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
