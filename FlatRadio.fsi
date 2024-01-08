namespace Fable.Form.Antidote.Field

module FlatRadioField =

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

    type FlatRadioField<'Values> = Field.Field<Attributes,string,'Values>

    val form<'Values, 'Field, 'Output> :
        ((FlatRadioField<'Values> -> 'Field) ->
        Base.FieldConfig<Attributes, string,'Values,'Output> ->
        Base.Form<'Values,'Output,'Field>)
