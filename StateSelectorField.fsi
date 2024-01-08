namespace Fable.Form.Antidote.Field

module StateSelectorField =

    open Fable.Form

    type Attributes = {
        Id: string
        Label: string
        Options: Map<string, string>
    }

    type StateSelectorField<'Values> = Field.Field<Attributes, string, 'Values>

    val form<'Values, 'Field, 'Output> :
        ((StateSelectorField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>)
