namespace Fable.Form.Antidote.Field

module CheckboxListField =

    open Fable.Form

    type Layout =
        | Horizontal
        | Vertical
    type Attributes =
        {
            Label: string
            Placeholder: string option
            Options: (string * string) list
            Layout: Layout
        }

    type CheckboxListField<'Values> = Field.Field<Attributes,Set<string>,'Values>

    let form<'Values, 'Field, 'Output> :
        ((CheckboxListField<'Values> -> 'Field) ->
        Base.FieldConfig<Attributes, Set<string>,'Values, 'Output> ->
        Base.Form<'Values,'Output,'Field>) =
            Base.field
                Set.isEmpty
