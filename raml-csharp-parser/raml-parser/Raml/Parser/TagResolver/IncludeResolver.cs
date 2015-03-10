﻿/*
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
using Raml.Parser.Raml.Parser.Utils;
using Raml.Parser.Raml.Parser.Visitor;

namespace Raml.Parser.Raml.Parser.TagResolver
{
    public class IncludeResolver
    {
        
    //public static readonly Tag INCLUDE_TAG = new Tag("!include");
    //public static readonly Tag INCLUDE_NOT_FOUND_TAG = new Tag("!include-not-found");
    public static readonly String SEPARATOR = "_";
    public static readonly String INCLUDE_APPLIED_TAG = "!include-applied" + SEPARATOR;
    private ContextPath contextPath;

    //@Override
    //public bool handles(Tag tag)
    //{
    //    return INCLUDE_TAG.equals(tag) || tag.startsWith(INCLUDE_APPLIED_TAG);
    //}

        //@Override
    //public Node resolve(Node node, ResourceLoader resourceLoader, NodeHandler nodeHandler)
    //{
    //    if (node.getTag().startsWith(INCLUDE_APPLIED_TAG))
    //    {
    //        //already resolved
    //        return node;
    //    }

    //    Node includeNode;
    //    if (node.getNodeId() != scalar)
    //    {
    //        nodeHandler.onCustomTagError(INCLUDE_TAG, node, "Include cannot be non-scalar");
    //        return mockInclude(node);
    //    }
    //    ScalarNode scalarNode = (ScalarNode) node;
    //    String resourceName = contextPath.resolveAbsolutePath(scalarNode.getValue());
    //    InputStream inputStream = resourceLoader.fetchResource(resourceName);

    //    if (inputStream == null)
    //    {
    //        nodeHandler.onCustomTagError(INCLUDE_TAG, node, "Include cannot be resolved " + resourceName);
    //        return mockInclude(node);
    //    }
    //    else if (resourceName.endsWith(".raml") || resourceName.endsWith(".yaml") || resourceName.endsWith(".yml"))
    //    {
    //        Yaml yamlParser = new Yaml();
    //        includeNode = yamlParser.compose(new InputStreamReader(inputStream));
    //    }
    //    else //scalar value
    //    {
    //        //String newValue = IOUtils.toString(inputStream);
    //        String newValue = StreamUtils.toString(inputStream);
    //        includeNode = new IncludeScalarNode(resourceName, newValue, scalarNode);
    //    }
    //    if (includeNode == null)
    //    {
    //        nodeHandler.onCustomTagError(INCLUDE_TAG, node, "Include file is empty " + resourceName);
    //        return mockInclude(node);
    //    }
    //    //retag node with included resource info
    //    String markInfo = node.getStartMark().getLine() + SEPARATOR + node.getStartMark().getColumn()
    //                      + SEPARATOR + node.getEndMark().getColumn();
    //    includeNode.setTag(new Tag(INCLUDE_APPLIED_TAG + resourceName + SEPARATOR + markInfo));
    //    return includeNode;
    //}

    //@Override
    //public void beforeProcessingResolvedNode(Tag tag, Node originalValueNode, Node resolvedNode)
    //{
    //    if (IncludeResolver.INCLUDE_TAG.equals(tag))
    //    {
    //        if (originalValueNode.getNodeId() != NodeId.scalar)
    //        {
    //            //invalid include
    //            return;
    //        }
    //        contextPath.push((ScalarNode) originalValueNode);
    //    }
    //    else if (tag.startsWith(IncludeResolver.INCLUDE_APPLIED_TAG))
    //    {
    //        contextPath.push(tag);
    //    }
    //}

    //@Override
    //public void afterProcessingResolvedNode(Tag tag, Node originalValueNode, Node resolvedNode)
    //{
    //    contextPath.pop();
    //}

    //private Node mockInclude(Node node)
    //{
    //    return new ScalarNode(INCLUDE_NOT_FOUND_TAG, "invalid", node.getStartMark(), node.getEndMark(), null);
    //}

    public void setContextPath(ContextPath contextPath)
    {
        this.contextPath = contextPath;
    }

    //@Override
    public ContextPath getContextPath()
    {
        return contextPath;
    }

    //public static class IncludeScalarNode extends ScalarNode
    //{

    //    private String includeName;

    //    public IncludeScalarNode(String includeName, String value, ScalarNode node)
    //    {
    //        super(Tag.STR, value, node.getStartMark(), node.getEndMark(), node.getStyle());
    //        this.includeName = includeName;
    //    }

    //    public String getIncludeName()
    //    {
    //        return includeName;
    //    }
    //}
    }
}
