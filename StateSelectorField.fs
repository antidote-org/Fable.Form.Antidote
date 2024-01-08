namespace Fable.Form.Antidote.Field

open Fable.Form

module StateSelectorField =

    type Attributes = {
        Id: string
        Label: string
        Options: Map<string, string>
    }

    type StateSelectorField<'Values> = Field.Field<Attributes, string, 'Values>

    let form<'Values, 'Field, 'Output> : ((StateSelectorField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
