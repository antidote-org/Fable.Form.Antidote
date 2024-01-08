namespace Fable.Form.Antidote.Field

open Fable.React

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
            /// <summary>
            /// Label to display
            /// </summary>
            Label: string
            Options: (string * string) list
        }

    type TagListField<'Values> = Field.Field<Attributes, Set<string>, 'Values>

    val form<'Values, 'Field, 'Output> :
        ((TagListField<'Values> -> 'Field) -> Base.FieldConfig<Attributes,Set<string>,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
