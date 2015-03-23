/*
 * Copyright 2015 (c) Sergio Martin Pueyo.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific
 * language governing permissions and limitations under the License.
 */
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

    //@Scalar
    private string _displayName;

    //@Scalar
    private string _description;

    //@Scalar
    private ParamType _type;

    //@Scalar
    private bool _required;

    //@Scalar
    private bool _repeat;

    //@Sequence(alias = "enum", rule = SequenceTupleNullsAllowedRule.class)
    private List<string> _enumeration;
    //@Scalar
    private string _pattern;
    //@Scalar
    private int _minLength;
    //@Scalar
    private int _maxLength;
    //@Scalar
    private decimal _minimum;
    //@Scalar
    private decimal _maximum;

    //@Scalar(alias = "default")
    private string _defaultValue;

    //@Scalar
    private string _example;

    //protected transient readonly Logger logger = LoggerFactory.getLogger(getClass());

    public AbstractParam()
    {
        //this.type = STRING;
    }

    public AbstractParam(string displayName, ParamType type, bool required)
    {
        this._displayName = displayName;
        this._type = type;
        this._required = required;
    }

    public void SetDisplayName(string displayName)
    {
        this._displayName = displayName;
    }

    public void SetDescription(string description)
    {
        this._description = description;
    }

    public void SetType(ParamType type)
    {
        this._type = type;
    }

    public void SetRequired(bool required)
    {
        this._required = required;
    }

    public string GetDisplayName()
    {
        return _displayName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public ParamType getType()
    {
        return _type;
    }

    public bool IsRequired()
    {
        return _required;
    }

    public bool IsRepeat()
    {
        return _repeat;
    }

    public void SetRepeat(bool repeat)
    {
        this._repeat = repeat;
    }

    public string GetDefaultValue()
    {
        return _defaultValue;
    }

    public string GetExample()
    {
        return _example;
    }

    public List<string> GetEnumeration()
    {
        return _enumeration;
    }

    public void SetEnumeration(List<string> enumeration)
    {
        this._enumeration = enumeration;
    }

    public string GetPattern()
    {
        return _pattern;
    }

    public void SetPattern(string pattern)
    {
        this._pattern = pattern;
    }

    public int GetMinLength()
    {
        return _minLength;
    }

    public void SetMinLength(int minLength)
    {
        this._minLength = minLength;
    }

    public int GetMaxLength()
    {
        return _maxLength;
    }

    public void SetMaxLength(int maxLength)
    {
        this._maxLength = maxLength;
    }

    public decimal GetMinimum()
    {
        return _minimum;
    }

    public void SetMinimum(decimal minimum)
    {
        this._minimum = minimum;
    }

    public decimal GetMaximum()
    {
        return _maximum;
    }

    public void SetMaximum(decimal maximum)
    {
        this._maximum = maximum;
    }

    public void SetDefaultValue(string defaultValue)
    {
        this._defaultValue = defaultValue;
    }

    public void SetExample(string example)
    {
        this._example = example;
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
