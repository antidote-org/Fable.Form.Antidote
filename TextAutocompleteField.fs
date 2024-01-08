namespace Fable.Form.Antidote.Field

open Fable.Form

module TextAutocompleteField =

    type Attributes =
        {
            Label : string
            Placeholder : string
            Possibilities : string list
        }

    type TextAutocompleteField<'Values> = Field.Field<Attributes,string,'Values>

    let form<'Values, 'Attributes, 'Field, 'Output> : ((TextAutocompleteField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
