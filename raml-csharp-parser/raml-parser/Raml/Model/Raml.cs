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
    public class Raml
    {

        //@Scalar(required = true)
        public string title { get; set; }

        //@Scalar()
        public string version { get; set; }

        //@Scalar(rule = org.raml.parser.rule.BaseUriRule.class)
        public string baseUri { get; set; }

        //@Sequence
        public List<Protocol> protocols { get; set; }

        //@Mapping(rule = org.raml.parser.rule.UriParametersRule.class)
        public Dictionary<String, UriParameter> baseUriParameters { get; set; }

        //@Scalar()
        public string mediaType { get; set; }

        //@Sequence(rule = org.raml.parser.rule.GlobalSchemasRule.class)
        public List<Dictionary<String, String>> schemas { get; set; }

        //@Sequence
        public List<Dictionary<String, Template>> resourceTypes { get; set; }

        //@Sequence
        public List<Dictionary<String, Template>> traits { get; set; }

        //@Sequence
        public List<Dictionary<String, SecurityScheme>> securitySchemes { get; set; }

        //@Sequence(rule = SecurityReferenceSequenceRule.class)
        public List<SecurityReference> securedBy { get; set; }

        //@Mapping(handler = ResourceHandler.class, implicit = true)
        public Dictionary<String, Resource> resources { get; set; }

        //@Sequence
        public List<DocumentationItem> documentation { get; set; }

        public Raml()
        {
        }

        //public String getBasePath()
        //{
        //    //skip protocol separator "//"
        //    int start = baseUri.indexOf("//") + 2;
        //    if (start == -1)
        //    {
        //        start = 0;
        //    }

        //    start = baseUri.indexOf("/", start);
        //    return baseUri.substring(start);
        //}

        //public String getUri()
        //{
        //    return "";
        //}


        //public Map<String, String> getConsolidatedSchemas()
        //{
        //    Map<String, String> consolidated = new HashMap<String, String>();
        //    for (Map<String, String> map : getSchemas())
        //    {
        //        consolidated.putAll(map);
        //    }
        //    return consolidated;
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
