namespace Fable.Form.Antidote.Field

module SwitchField =

    open Fable.Form

    type Attributes =
        {
            Text: string
            Id : string
        }

    type SwitchField<'Values> = Field.Field<Attributes,bool,'Values>

    val form<'Values,'Field,'Output> :
        ((SwitchField<'Values> -> 'Field) -> Base.FieldConfig<Attributes,bool,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
