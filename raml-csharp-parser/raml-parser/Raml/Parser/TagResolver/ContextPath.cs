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
using Raml.Parser.Raml.Parser.Visitor;

namespace Raml.Parser.Raml.Parser.TagResolver
{
    public class ContextPath
    {
        private Queue<IncludeInfo> includeStack = new Queue<IncludeInfo>();

        public ContextPath()
        {
        }

        public ContextPath(ContextPath contextPath)
        {
            this.includeStack = new Queue<IncludeInfo>(contextPath.includeStack);
        }

        public void pushRoot(String absoluteFile)
        {
            if (includeStack.Count > 0)
            {
                throw new System.InvalidOperationException("Non empty stack");
            }
            includeStack.Enqueue(new IncludeInfo(absoluteFile));
        }

        public static String resolveAbsolutePath(string relativeFile, string parentPath)
        {
            //check if it is absolute
            if (relativeFile.StartsWith("classpath:"))
            {
                return relativeFile.Substring(relativeFile.IndexOf(":") + 1);
            }
            if (relativeFile.StartsWith("http:") ||
                relativeFile.StartsWith("https:") ||
                relativeFile.StartsWith("file:"))
            {
                return relativeFile;
            }
            return parentPath + relativeFile;
        }

        public String resolveAbsolutePath(String relativeFile)
        {
            return resolveAbsolutePath(relativeFile, getPartentPath());
        }

        private String getPartentPath()
        {
            int idx = includeStack.Peek().IncludeName.LastIndexOf("/") + 1;
            return includeStack.Peek().IncludeName.Substring(0, idx);
        }

        public IncludeInfo peek()
        {
            return includeStack.Peek();
        }

        public IncludeInfo pop()
        {
            return includeStack.Dequeue();
        }

        //public void push(IncludeInfo includeInfo)
        //{
        //    includeStack.push(includeInfo);
        //}

        //public void push(ScalarNode node)
        //{
        //    push(new IncludeInfo(node, getPartentPath()));
        //}

        //public void push(Tag tag)
        //{
        //    push(new IncludeInfo(tag));
        //}

        public int size()
        {
            return includeStack.Count();
        }
    }
}
