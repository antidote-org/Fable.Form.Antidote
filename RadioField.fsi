namespace Fable.Form.Antidote.Field

module RadioField =

    open Fable.Form

    type Layout =
        | Horizontal
        | Vertical

    type Attributes =
        {
            Label: string
            Options: (string * string) list
            Layout: Layout
        }

    type RadioField<'Values> = Field.Field<Attributes,string,'Values>

    val form<'Values,'Field,'Output> :
        ((RadioField<'Values> -> 'Field) -> Base.FieldConfig<Attributes,string,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
