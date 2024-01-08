namespace Fable.Form.Antidote.Field

module FlatRadioField =

    open Fable.Form

    type Attributes =
        {
            Label: string
            Placeholder: string option
            Options: (string * string) list
        }

    type FlatRadioField<'Values> = Field.Field<Attributes,string,'Values>

    let form<'Values, 'Field, 'Output> :
        ((FlatRadioField<'Values> -> 'Field) ->
        Base.FieldConfig<Attributes, string,'Values, 'Output> ->
        Base.Form<'Values,'Output,'Field>) =
            Base.field
                System.String.IsNullOrEmpty
