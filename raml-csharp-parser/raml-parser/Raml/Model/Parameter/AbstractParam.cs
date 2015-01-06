using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raml.Parser.Raml.Model.Parameter
{
    [Serializable]
    public class AbstractParam
    {
        private static readonly long serialVersionUID = 7834134766509227575L;

    //@Scalar
    private string displayName;

    //@Scalar
    private string description;

    //@Scalar
    private ParamType type;

    //@Scalar
    private bool required;

    //@Scalar
    private bool repeat;

    //@Sequence(alias = "enum", rule = SequenceTupleNullsAllowedRule.class)
    private List<string> enumeration;
    //@Scalar
    private string pattern;
    //@Scalar
    private int minLength;
    //@Scalar
    private int maxLength;
    //@Scalar
    private decimal minimum;
    //@Scalar
    private decimal maximum;

    //@Scalar(alias = "default")
    private string defaultValue;

    //@Scalar
    private string example;

    //protected transient readonly Logger logger = LoggerFactory.getLogger(getClass());

    public AbstractParam()
    {
        //this.type = STRING;
    }

    public AbstractParam(string displayName, ParamType type, bool required)
    {
        this.displayName = displayName;
        this.type = type;
        this.required = required;
    }

    public void setDisplayName(string displayName)
    {
        this.displayName = displayName;
    }

    public void setDescription(string description)
    {
        this.description = description;
    }

    public void setType(ParamType type)
    {
        this.type = type;
    }

    public void setRequired(bool required)
    {
        this.required = required;
    }

    public string getDisplayName()
    {
        return displayName;
    }

    public string getDescription()
    {
        return description;
    }

    public ParamType getType()
    {
        return type;
    }

    public bool isRequired()
    {
        return required;
    }

    public bool isRepeat()
    {
        return repeat;
    }

    public void setRepeat(bool repeat)
    {
        this.repeat = repeat;
    }

    public string getDefaultValue()
    {
        return defaultValue;
    }

    public string getExample()
    {
        return example;
    }

    public List<string> getEnumeration()
    {
        return enumeration;
    }

    public void setEnumeration(List<string> enumeration)
    {
        this.enumeration = enumeration;
    }

    public string getPattern()
    {
        return pattern;
    }

    public void setPattern(string pattern)
    {
        this.pattern = pattern;
    }

    public int getMinLength()
    {
        return minLength;
    }

    public void setMinLength(int minLength)
    {
        this.minLength = minLength;
    }

    public int getMaxLength()
    {
        return maxLength;
    }

    public void setMaxLength(int maxLength)
    {
        this.maxLength = maxLength;
    }

    public decimal getMinimum()
    {
        return minimum;
    }

    public void setMinimum(decimal minimum)
    {
        this.minimum = minimum;
    }

    public decimal getMaximum()
    {
        return maximum;
    }

    public void setMaximum(decimal maximum)
    {
        this.maximum = maximum;
    }

    public void setDefaultValue(string defaultValue)
    {
        this.defaultValue = defaultValue;
    }

    public void setExample(string example)
    {
        this.example = example;
    }

    //public bool validate(string value)
    //{
    //    return OK.equals(message(value));
    //}

    //public string message(string value)
    //{
    //    if (type == null)
    //    {
    //        type = STRING;
    //    }
    //    return type.message(this, value);
    //}

    }
}
