namespace Fable.Form.Antidote.Field

open Fable.React

module ReactComponentField =

    open Fable.Form
    open Feliz

    type ReactComponentFieldProps =
        {
            Value : string
            OnChange : string -> unit
            Disabled : bool
        }

    type Attributes =
        {
            /// <summary>
            /// Label to display
            /// </summary>
            Label: string
            Render : ReactComponentFieldProps -> ReactElement
        }

    type ReactComponentField<'Values> = Field.Field<Attributes,string,'Values>

    val form<'Values, 'Field, 'Output> :
        ((ReactComponentField<'Values> -> 'Field) -> Base.FieldConfig<Attributes,string,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
