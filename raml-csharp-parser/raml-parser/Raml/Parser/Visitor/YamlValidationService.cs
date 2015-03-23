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
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.Build.Utilities;
using Raml.Parser.Raml.Parser.Loader;
using Raml.Parser.Raml.Parser.Rule;
using Raml.Parser.Raml.Parser.Utils;
using Raml.Parser.Raml.Parser.TagResolver;

namespace Raml.Parser.Raml.Parser.Visitor
{
    public class YamlValidationService
    {
    
    private static readonly ILog Logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

    private List<ValidationResult> _errorMessage;
    private YamlValidator _yamlValidator;
    private ResourceLoader _resourceLoader;
    private TagResolver.TagResolver[] _tagResolvers;

    protected YamlValidationService(ResourceLoader resourceLoader, YamlValidator yamlValidator, TagResolver.TagResolver[] tagResolvers)
    {
        this._resourceLoader = resourceLoader;
        this._yamlValidator = yamlValidator;
        this._errorMessage = new List<ValidationResult>();
        this._tagResolvers = tagResolvers;
    }

    //public List<ValidationResult> validate(MappingNode root, String resourceLocation)
    //{
    //    NodeVisitor nodeVisitor = new NodeVisitor(_yamlValidator, _resourceLoader, _tagResolvers);
    //    _yamlValidator.getContextPath().pushRoot(resourceLocation);
    //    _errorMessage.addAll(preValidation(root));
    //    nodeVisitor.visitDocument(root);
    //    return _errorMessage;
    //}

    //public List<ValidationResult> validate(String resourceLocation)
    //{
    //    InputStream resourceStream = _resourceLoader.fetchResource(resourceLocation);
    //    return validate(resourceStream, resourceLocation);
    //}

    //public List<ValidationResult> validate(String content, String resourceLocation)
    //{
    //    return validate(new StringReader(content), resourceLocation);
    //}

    //public List<ValidationResult> validate(InputStream content, String resourceLocation)
    //{
    //    return validate(StreamUtils.reader(content), resourceLocation);
    //}

    //public List<ValidationResult> validate(Reader content, String resourceLocation)
    //{
    //    long startTime = currentTimeMillis();

    //    try
    //    {
    //        Yaml yamlParser = new Yaml();
    //        Node root = yamlParser.compose(content);
    //        if (root != null && root.getNodeId() == mapping)
    //        {
    //            validate((MappingNode) root, resourceLocation);
    //        }
    //        else
    //        {
    //            _errorMessage.add(createErrorResult("Invalid RAML"));
    //        }
    //    }
    //    catch (MarkedYAMLException mye)
    //    {
    //        _errorMessage.add(createErrorResult(mye.getProblem(), mye.getProblemMark(), mye.getProblemMark()));
    //    }
    //    catch (YAMLException ex)
    //    {
    //        _errorMessage.add(createErrorResult(ex.getMessage()));
    //    }
    //    finally
    //    {
    //        IOUtils.closeQuietly(content);
    //    }

    //    _errorMessage.addAll(_yamlValidator.getMessages());

    //    if (Logger.isDebugEnabled())
    //    {
    //        Logger.debug("validation time: " + (currentTimeMillis() - startTime) + "ms.");
    //    }

    //    return _errorMessage;
    //}

    //@Deprecated
    //public List<ValidationResult> validate(Reader content)
    //{
    //    return validate(content, new File("").getPath());
    //}

    //@Deprecated
    //public List<ValidationResult> validate(InputStream content)
    //{
    //    return validate(StreamUtils.reader(content));
    //}

    //protected List<ValidationResult> preValidation(MappingNode root)
    //{
    //    //template method
    //    return new List<ValidationResult>();
    //}

    //protected YamlValidator getValidator()
    //{
    //    return _yamlValidator;
    //}
    }
}
