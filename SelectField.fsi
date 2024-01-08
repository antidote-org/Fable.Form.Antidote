namespace Fable.Form.Antidote.Field

module SelectField =

    open Fable.Form

    type Attributes<'Attributes> =
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
            /// <summary>
            /// A list of HTML attributes to add to the generated field
            ///
            /// This is added to the input element
            /// </summary>
            HtmlAttributes: 'Attributes list
        }

    type SelectField<'Values, 'Attributes> = Field.Field<Attributes<'Attributes>,string,'Values>

    val form<'Values,'Attributes,'Field,'Output> :
        ((SelectField<'Values, 'Attributes> -> 'Field) -> Base.FieldConfig<Attributes<'Attributes>,string,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
