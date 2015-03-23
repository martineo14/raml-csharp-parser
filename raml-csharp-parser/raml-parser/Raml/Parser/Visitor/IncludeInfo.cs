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
using Raml.Parser.Raml.Parser.TagResolver;


namespace Raml.Parser.Raml.Parser.Visitor
{
    public class IncludeInfo
    {
        public int Line { get; set; }
        public int StartColumn { get; set; }
        public int EndColumn { get; set; }
        public String IncludeName { get; set; }

        public IncludeInfo(int line, int startColumn, int endColumn, string includeName)
        {
            this.Line = line;
            this.StartColumn = startColumn;
            this.EndColumn = endColumn;
            this.IncludeName = includeName;
        }

        //public IncludeInfo(Mark startMark, Mark endMark, string includeName)
        //{
        //    return new IncludeInfo(startMark.getLine(), startMark.getColumn(), endMark.getColumn(), includeName);
        //}

        //public IncludeInfo(ScalarNode node, String parentPath)
        //{
        //    return new IncludeInfo(node.getStartMark(), node.getEndMark(), resolveAbsolutePath(node.getValue(), parentPath));
        //}

        //public IncludeInfo(Tag tag)
        //{
        //    StringBuilder encodedInclude = new StringBuilder(tag.getValue());
        //    EndColumn = popTrailingNumber(encodedInclude);
        //    StartColumn = popTrailingNumber(encodedInclude);
        //    Line = popTrailingNumber(encodedInclude);
        //    IncludeName = encodedInclude.ToString().Substring((IncludeResolver.INCLUDE_APPLIED_TAG.length()));
        //}

        public IncludeInfo(String name)
        {
            this.IncludeName = name;
        }

        private int PopTrailingNumber(StringBuilder encodedInclude)
        {
            int idx = encodedInclude.ToString().LastIndexOf(IncludeResolver.Separator);
            int result = Int32.Parse(encodedInclude.ToString().Substring(idx + 1));
            encodedInclude.Remove(idx, encodedInclude.Length);
            return result;
        }

    }
}
