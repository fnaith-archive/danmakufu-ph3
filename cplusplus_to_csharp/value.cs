public class value
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public value(type_data t, string v)
    {
    // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
        data = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new body();
        data.ref_count = 1;
        data.type = t;
        if (false)
        {
            ;
        }
        else
        {
            for (uint i = 0; i < v.Length; ++i) data.array_value.push_back(new value(t.get_element(), v[i]));
        }
    #if _TRACE_VALUE
        id = counter++;
        // if (is_target()) throw std::exception("V6");
    #endif
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void append(type_data t, value x)
    {
        unique();
        data.type = t;
        data.array_value.push_back(x);
    #if _TRACE_VALUE
        if (is_target())
        {
            Console.Write("V:append ");
            Console.Write(to_mbcs(this.as_string()));
            Console.Write("\n");
        }
    #endif
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void concatenate(value x)
    {
        unique();
        uint l = data.array_value.length;
        uint r = x.data.array_value.length;
        uint t = l + r;
        if (l == 0)
        {
            data.type = x.data.type;
        }
        while (data.array_value.capacity < t)
        {
            data.array_value.expand();
        }
        if (false)
        {
            ;
        }
        else
        {
            for (uint i = 0; i < r; ++i) data.array_value[l + i] = x.data.array_value.at[i];
        }
        data.array_value.length = t;
    #if _TRACE_VALUE
        if (is_target())
        {
            Console.Write("V:concatenate ");
            Console.Write(to_mbcs(this.as_string()));
            Console.Write("\n");
        }
    #endif
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public double as_real()
    {
        if (data == null)
        {
            return 0.0;
        }
        else
        {
            switch (data.type.get_kind())
            {
                case type_data.tk_real:
                    return data.real_value;
                case type_data.tk_char:
                    return (double) data.char_value;
                case type_data.tk_boolean:
                    return (data.boolean_value) ? 1.0 : 0.0;
                case type_data.tk_array:
                    if (data.type.get_element().get_kind() == type_data.tk_char)
                    {
                        return Convert.ToDouble(to_mbcs(as_string()).c_str());
                    }
                    else
                    {
                        return 0.0;
                    }
                default:
                    Debug.Assert(false);
                    return 0.0;
            }
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public char as_char()
    {
        if (data == null)
        {
            return 0.0;
        }
        else
        {
            switch (data.type.get_kind())
            {
                case type_data.tk_real:
                    return data.real_value;
                case type_data.tk_char:
                    return data.char_value;
                case type_data.tk_boolean:
                    return (data.boolean_value) ? '1' : '0';
                case type_data.tk_array:
                    return '\0';
                default:
                    Debug.Assert(false);
                    return '\0';
            }
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public bool as_boolean()
    {
        if (data == null)
        {
            return false;
        }
        else
        {
            switch (data.type.get_kind())
            {
                case type_data.tk_real:
                    return data.real_value != 0.0;
                case type_data.tk_char:
                    return data.char_value != '\0';
                case type_data.tk_boolean:
                    return data.boolean_value;
                case type_data.tk_array:
                    return data.array_value.size() != 0;
                default:
                    Debug.Assert(false);
                    return false;
            }
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public string as_string()
    {
        if (data == null)
        {
            return "(VOID)";
        }
    
        else
        {
            switch (data.type.get_kind())
            {
                case type_data.tk_real:
                {
                        string buffer = new string(new char[128]);
                        std::swprintf(buffer, "%Lf", data.real_value);
                        return new string(buffer);
                }
    
                case type_data.tk_char:
                {
                        string result;
                        result += data.char_value;
                        return result;
                }
    
                case type_data.tk_boolean:
                    return (data.boolean_value) ? "true" : "false";
    
                case type_data.tk_array:
                {
                        if (data.type.get_element().get_kind() == type_data.tk_char)
                        {
                            string result;
                            if (false)
                            {
                                ;
                            }
                            else
                            {
                                for (uint i = 0; i < data.array_value.size(); ++i) result += data.array_value[i].as_char();
                            }
                            return result;
                        }
                        else
                        {
                            string result = "[";
                            if (false)
                            {
                                ;
                            }
                            else
                            {
                                for (uint i = 0; i < data.array_value.size(); ++i)
                                {
                                result += data.array_value[i].as_string();
                                if (i != data.array_value.size() - 1)
                                {
                                    result += ",";
                                }
                                }
                            }
                            result += "]";
                            return result;
                        }
                }
    // C++ TO C# CONVERTER TODO TASK: C# does not allow fall-through from a non-empty 'case':
                default:
                    Debug.Assert(false);
                    return "(INTERNAL-ERROR)";
            }
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public uint length_as_array()
    {
        Debug.Assert(data != null && data.type.get_kind() == type_data.tk_array);
        return data.array_value.size();
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public value index_as_array(uint i)
    {
        Debug.Assert(data != null && data.type.get_kind() == type_data.tk_array);
        Debug.Assert(i < data.array_value.length);
        return data.array_value[i];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public value index_as_array(uint i)
    {
        Debug.Assert(data != null && data.type.get_kind() == type_data.tk_array);
        Debug.Assert(i < data.array_value.length);
        return data.array_value[i];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public type_data get_type()
    {
        Debug.Assert(data != null);
        return data.type;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void overwrite(value source)
    {
    #if _TRACE_VALUE
        if (is_target() || source.is_target())
        {
            Console.Write("V:overwrite this ");
            Console.Write((this.id));
            Console.Write("=");
            Console.Write(to_mbcs(this.as_string()));
            Console.Write("\n");
            Console.Write("V:overwrite source ");
            Console.Write((source.id));
            Console.Write("=");
            Console.Write(to_mbcs(source.as_string()));
            Console.Write("\n");
        }
    #endif
        Debug.Assert(data != null);
        if (data == source.data)
        {
            return;
        }
    
        release();
        * data = * source.data;
        data.ref_count = 2;
    
    // 	* data = * source.data;
    // 	++(data->ref_count);
    }
}