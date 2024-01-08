namespace Fable.Form.Antidote.Field

module TagListField =

    open Fable.Form
    open Feliz

    type TagListFieldProps =
        {
            Value : string
            OnChange : string -> unit
        }

    type Attributes =
        {
            Label: string
            Options : (string * string) list
        }

    type TagListField<'Values> = Field.Field<Attributes,Set<string>,'Values>

    let form<'Values, 'Field, 'Output> : ((TagListField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, Set<string>, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            Set.isEmpty
