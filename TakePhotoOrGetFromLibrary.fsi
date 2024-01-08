namespace Fable.Form.Antidote.Field

module TakePhotoOrGetFromLibrary =

    open Fable.Form

    type Attributes =
        {
            /// <summary>
            /// Label to display
            /// </summary>
            Label: string
        }

    type TakePhotoOrGetFromLibrary<'Values> = Field.Field<Attributes,string,'Values>

    val form<'Values,'Field,'Output> :
        ((TakePhotoOrGetFromLibrary<'Values> -> 'Field) -> Base.FieldConfig<Attributes,string,'Values,'Output> -> Base.Form<'Values,'Output,'Field>)
