namespace Fable.Form.Antidote.Field

module DependentTextAutocompleteField =

    open Fable.Form

    type Attributes =
        {
            /// <summary>
            /// Label to display
            /// </summary>
            Label: string
            /// <summary>
            /// Placeholder to display when the field is empty
            /// </summary>
            Placeholder: string
            Possibilities: string list
        }

    type DependentTextAutocompleteField<'Values> = Field.Field<Attributes,string,'Values>

    val form<'Values,'Attributes,'Field,'Output> :
        ((DependentTextAutocompleteField<'Values> -> 'Field) -> Base.FieldConfig<Attributes,string,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
