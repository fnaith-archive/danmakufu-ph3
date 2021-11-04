public class script_type_manager
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public script_type_manager()
    {
        real_type = & * types.insert(types.end(), new type_data(type_data.tk_real));
        char_type = & * types.insert(types.end(), new type_data(type_data.tk_char));
        boolean_type = & * types.insert(types.end(), new type_data(type_data.tk_boolean));
        string_type = & * types.insert(types.end(), new type_data(type_data.tk_array, char_type));
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public type_data get_array_type(type_data element)
    {
        if (false)
        {
            ;
        }
        else
        {
            for (LinkedList<type_data>.Enumerator i = types.begin(); i.MoveNext();)
            {
            if (i.get_kind() == type_data.tk_array && i.get_element() == element)
            {
    // C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                return new gstd.type_data(i);
            }
            }
        }
        return  * types.insert(types.end(), new type_data(type_data.tk_array, element));
    }
}