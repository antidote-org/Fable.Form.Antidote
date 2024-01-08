namespace Fable.Form.Antidote.Field

open Fable.Form

module TakePhotoOrGetFromLibrary =

    type Attributes =
        {
            Label : string
        }

    type TakePhotoOrGetFromLibrary<'Values> = Field.Field<Attributes,string,'Values>

    let form<'Values, 'Field, 'Output> : ((TakePhotoOrGetFromLibrary<'Values> -> 'Field) -> Base.FieldConfig<Attributes, string, 'Values, 'Output> -> Base.Form<'Values, 'Output, 'Field>) =
        Base.field
            System.String.IsNullOrEmpty
