namespace Fable.Form.Antidote.Field

module FlatCheckboxField =

    open Fable.Form

    type Attributes =
        {
            Label: string
            Placeholder: string option
            Options: (string * string) list
        }

    type FlatCheckboxField<'Values> = Field.Field<Attributes,Set<string>,'Values>

    let form<'Values, 'Field, 'Output> :
        ((FlatCheckboxField<'Values> -> 'Field) ->
        Base.FieldConfig<Attributes, Set<string>,'Values, 'Output> ->
        Base.Form<'Values,'Output,'Field>) =
            Base.field
                Set.isEmpty
