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
using Raml.Parser.Raml.Parser.Utils;
using Raml.Parser.Raml.Parser.Visitor;
using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace Raml.Parser.Raml.Parser.TagResolver
{
    public class IncludeResolver : TagResolver
    {

        public static readonly Tag IncludeTag = new Tag("!include", "!include");
        public static readonly Tag IncludeNotFoundTag = new Tag("!include-not-found", "!include-not-found");
        public static readonly string Separator = "_";
        public static readonly string IncludeAppliedTag = "!include-applied" + Separator;
        public ContextPath contextPath { get; private set; }

        public override bool Handles(Tag tag)
        {
            return IncludeTag.Equals(tag) || tag.ToString().StartsWith(IncludeAppliedTag);
        }

        public override YamlNode Resolve(YamlNode node, ResourceLoader resourceLoader, NodeHandler nodeHandler)
        {
            if (node.Tag.StartsWith(IncludeAppliedTag))
            {
                //already resolved
                return node;
            }

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


            //private Node mockInclude(Node node)
            //{
            //    return new ScalarNode(INCLUDE_NOT_FOUND_TAG, "invalid", node.getStartMark(), node.getEndMark(), null);
            //}

        

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
            return node;
        }

        public override void BeforeProcessingResolvedNode(Tag tag, YamlNode originalValueNode, YamlNode resolvedNode)
        {
            //if (IncludeResolver.IncludeTag.Equals(tag))
            //{
            //    if (originalValueNode.getNodeId() != NodeId.scalar)
            //    {
            //        //invalid include
            //        return;
            //    }
            //    contextPath.PushRoot((ScalarNode) originalValueNode);
            //}
            //else if (tag.startsWith(IncludeResolver.INCLUDE_APPLIED_TAG))
            //{
            //    contextPath.push(tag);
            //}
        }

        public override void AfterProcessingResolvedNode(Tag tag, YamlNode originalNode, YamlNode resolvedNode)
        {
            contextPath.Pop();
        }
    }
}
