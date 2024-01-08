namespace Fable.Form.Antidote.Field

module FlatCheckboxField =

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
            Placeholder: string option
            Options: (string * string) list
        }

    type FlatCheckboxField<'Values> = Field.Field<Attributes,Set<string>,'Values>

    val form<'Values, 'Field, 'Output> :
        ((FlatCheckboxField<'Values> -> 'Field) ->
        Base.FieldConfig<Attributes,Set<string>,'Values,'Output> ->
        Base.Form<'Values,'Output,'Field>)
