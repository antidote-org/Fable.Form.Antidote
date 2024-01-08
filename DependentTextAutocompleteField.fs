namespace Fable.Form.Antidote.Field

open Fable.Form

module DependentTextAutocompleteField =

    type Attributes =
        {
            Label : string
            Placeholder : string
            Possibilities : string list
        }

    type DependentTextAutocompleteField<'Values> = Field.Field<Attributes,string,'Values>

    let form<'Values, 'Attributes, 'Field, 'Output> : ((DependentTextAutocompleteField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
