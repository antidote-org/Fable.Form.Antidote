namespace Fable.Form.Antidote.Field

module TextAutocompleteField =

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

    type TextAutocompleteField<'Values> = Field.Field<Attributes,string,'Values>

    val form<'Values,'Attributes,'Field,'Output> :
        ((TextAutocompleteField<'Values> -> 'Field) -> Base.FieldConfig<Attributes,string,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
