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
using Raml.Parser.Raml.Parser.Loader;
using Raml.Parser.Raml.Parser.Rule;
using Raml.Parser.Raml.Parser.TagResolver;

namespace Raml.Parser.Raml.Parser.Visitor
{
    public class RamlValidationService : YamlValidationService
    {
    //    public RamlValidationService(ResourceLoader resourceLoader, RamlDocumentValidator ramlDocumentValidator, TagResolver.TagResolver[] tagResolvers)
    //{
    //    base(resourceLoader, ramlDocumentValidator, DefaultResolver(tagResolvers));
    //    GetValidator().setResourceLoader(resourceLoader);
    //}

    //private static TagResolver.TagResolver[] DefaultResolver(TagResolver.TagResolver[] tagResolvers)
    //{
    //    TagResolver.TagResolver[] defaultResolvers = new TagResolver.TagResolver[] {
    //            new IncludeResolver(),
    //            new PojoValidatorTagResolver()
    //    };
    //    return (TagResolver.TagResolver[]) ArrayUtils.addAll(defaultResolvers, tagResolvers);
    //}

    ////@Override
    //protected List<ValidationResult> PreValidation(MappingNode root)
    //{
    //    List<ValidationResult> validationResults = GetValidator().getTemplateResolver().init(root);
    //    validationResults.addAll(GetValidator().getMediaTypeResolver().beforeDocumentStart(root));
    //    return validationResults;
    //}

    //public static RamlValidationService createDefault()
    //{
    //    return createDefault(new DefaultResourceLoader());
    //}

    //public static RamlValidationService createDefault(ResourceLoader loader, NodeRuleFactory nodeRuleFactory, TagResolver.TagResolver[] tagResolvers)
    //{
    //    return createDefault(loader, new NodeRuleFactory(), tagResolvers);
    //}

    //public static RamlValidationService createDefault(ResourceLoader loader, NodeRuleFactory nodeRuleFactory, TagResolver.TagResolver[] tagResolvers)
    //{
    //    return new RamlValidationService(loader, new RamlDocumentValidator(nodeRuleFactory), tagResolvers);
    //}

    ////@Override
    //protected RamlDocumentValidator GetValidator()
    //{
    //    return base.getValidator();
    //}
        protected RamlValidationService(ResourceLoader resourceLoader, YamlValidator yamlValidator, TagResolver.TagResolver[] tagResolvers) : base(resourceLoader, yamlValidator, tagResolvers)
        {
        }
    }
}
