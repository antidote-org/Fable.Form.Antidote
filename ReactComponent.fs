namespace Fable.Form.Antidote.Field

module ReactComponentField =

    open Fable.Form
    open Feliz
    open Fable.React


    type ReactComponentFieldProps =
        {
            Value : string
            OnChange : string -> unit
            Disabled : bool
        }

    type Attributes =
        {
            Label: string
            Render : ReactComponentFieldProps -> ReactElement
        }

    type ReactComponentField<'Values> = Field.Field<Attributes,string,'Values>

    let form<'Values, 'Field, 'Output> : ((ReactComponentField<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
