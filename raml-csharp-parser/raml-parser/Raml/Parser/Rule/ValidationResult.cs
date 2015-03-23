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
using Raml.Parser.Raml.Parser.TagResolver;
using Raml.Parser.Raml.Parser.Visitor;

namespace Raml.Parser.Raml.Parser.Rule
{
    public class ValidationResult
    {
        public enum Level
        {
            Error,
            Warn,
            Info
        }

        public static readonly int Unknown = -1;
        private readonly int _endColumn;
        public readonly Level level;
        public readonly int Line;
        public readonly String Message;
        private readonly int _startColumn;
        private ContextPath _contextPath;
        private IncludeInfo _extraIncludeInfo;

        private ValidationResult(Level level, String message, int line, int startColumn, int endColumn)
        {
            this.level = level;
            this.Message = message;
            this.Line = line;
            this._startColumn = startColumn;
            this._endColumn = endColumn;
        }

        public bool IsValid()
        {
            return level != Level.Error;
        }

        public String GetIncludeName()
        {
            if (_contextPath != null && _contextPath.Size() > 1)
            {
                return _contextPath.Peek().IncludeName;
            }
            return null;
        }

        public ContextPath GetIncludeContext()
        {
            return _contextPath;
        }

        public void SetIncludeContext(ContextPath contextPath)
        {
            this._contextPath = new ContextPath(contextPath);
            //if (extraIncludeInfo != null)
            //{
            //    this.contextPath.push(extraIncludeInfo);
            //    extraIncludeInfo = null;
            //}
        }

        public void SetExtraIncludeInfo(IncludeInfo extraIncludeInfo)
        {
            this._extraIncludeInfo = extraIncludeInfo;
        }

        public static bool AreValid(List<ValidationResult> validationResults)
        {
            return validationResults.All(result => result.IsValid());
        }

        public static List<ValidationResult> GetLevel(Level level, List<ValidationResult> results)
        {
            return results.Where(result => result.level == level).ToList();
        }

        //private @Override 

        public String toString()
        {
            return "ValidationResult{" +
                   "level=" + level +
                   ", message='" + Message + '\'' +
                   '}';
        }

        public static ValidationResult createErrorResult(String message, int line, int startIndex, int endIndex)
        {
            return new ValidationResult(Level.Error, message, line, startIndex, endIndex);
        }

        //public static ValidationResult createErrorResult(String message, Mark startMark, Mark endMark)
        //{
        //    int line = startMark == null ? UNKNOWN : startMark.getLine();
        //    int startColumn = startMark == null ? UNKNOWN : startMark.getColumn();
        //    int endColumn = endMark == null ? UNKNOWN : endMark.getColumn();
        //    return createErrorResult(message, line, startColumn, endColumn);
        //}

        //public static ValidationResult createErrorResult(String message, Node node)
        //{
        //    return createErrorResult(message, node.getStartMark(), node.getEndMark());
        //}

        public static ValidationResult createErrorResult(String message)
        {
            return createErrorResult(message, Unknown, Unknown, Unknown);
        }

        //public static ValidationResult createWarnResult(String message, Node node)
        //{
        //    return new ValidationResult(Level.WARN, message, node.getStartMark().getLine(),
        //        node.getStartMark().getColumn(), node.getEndMark().getColumn());
        //}

        public static ValidationResult Create(Level level, String message)
        {
            return new ValidationResult(level, message, Unknown, Unknown, Unknown);
        }
    }
}