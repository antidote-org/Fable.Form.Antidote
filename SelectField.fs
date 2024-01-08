namespace Fable.Form.Antidote.Field

open Fable.Form

module SelectField =

    type Attributes<'Attributes> =
        {
            Label : string
            Placeholder : string option
            Options : (string * string) list
            HtmlAttributes: 'Attributes list
        }

    type SelectField<'Values, 'Attributes> = Field.Field<Attributes<'Attributes>,string,'Values>

    let form<'Values, 'Attributes, 'Field, 'Output> : ((SelectField<'Values,  'Attributes> -> 'Field) -> Base.FieldConfig<Attributes<'Attributes>, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
