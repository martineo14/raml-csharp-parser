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
using Raml.Parser.Raml.Model.Parameter;

namespace Raml.Parser.Raml.Model
{
    [Serializable]
    public class Resource
    {

        //@Parent
        public Resource ParentResource { get; set; }

        //@Scalar
        public string DisplayName { get; set; }

        //@Scalar
        public string Description { get; set; }

        //@Parent(property = "uri")
        public string ParentUri { get; set; }

        //@Key
        public string RelativeUri { get; set; }

        //@Mapping
        public Dictionary<String, UriParameter> UriParameters { get; set; }

        //@Scalar
        public string Type { get; set; }

        //@Sequence
        public List<String> Resourceis { get; set; }

        //@Sequence(rule = SecurityReferenceSequenceRule.class)
        public List<SecurityReference> SecuredBy { get; set; }

        //@Mapping(rule = org.raml.parser.rule.UriParametersRule.class)
        public Dictionary<String, List<UriParameter>> BaseUriParameters { get; set; }

        //@Mapping(implicit = true)
        public Dictionary<ActionType, Action> Actions { get; set; }

        //@Mapping(handler = ResourceHandler.class, implicit = true)
        public Dictionary<String, Resource> Resources { get; set; }

        public Resource()
        {
        }

        ////@Override
        //public bool equals(Object o)
        //{
        //    if (this == o)
        //    {
        //        return true;
        //    }
        //    if (!(o instanceof Resource))
        //    {
        //        return false;
        //    }

        //    Resource resource = (Resource) o;

        //    return parentUri.equals(resource.parentUri) && relativeUri.equals(resource.relativeUri);

        //}

        ////@Override
        //public int hashCode()
        //{
        //    int result = parentUri.hashCode();
        //    result = 31 * result + relativeUri.hashCode();
        //    return result;
        //}

        ////@Override
        //public String toString()
        //{
        //    return "Resource{displayName='" + displayName + '\'' +
        //           ", uri='" + (parentUri != null ? getUri() : "-") + "'}";
        //}

        //public Resource getResource(String path)
        //{
        //    for (Resource resource : resources.values())
        //    {
        //        if (path.startsWith(resource.getRelativeUri()))
        //        {
        //            if (path.length() == resource.getRelativeUri().length())
        //            {
        //                return resource;
        //            }
        //            if (path.charAt(resource.getRelativeUri().length()) == '/')
        //            {
        //                return resource.getResource(path.substring(resource.getRelativeUri().length()));
        //            }
        //        }
        //    }
        //    return null;
        //}
    }
}
