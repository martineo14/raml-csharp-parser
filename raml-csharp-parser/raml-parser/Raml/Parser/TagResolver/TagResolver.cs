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

using Raml.Parser.Raml.Parser.Loader;
using Raml.Parser.Raml.Parser.Visitor;
using YamlDotNet.Core.Tokens;
using YamlDotNet.RepresentationModel;

namespace Raml.Parser.Raml.Parser.TagResolver
{
    public abstract class TagResolver
    {
        public abstract bool Handles(Tag tag);
        public abstract YamlNode Resolve(YamlNode valueNode, ResourceLoader resourceLoader, NodeHandler nodeHandler);
        public abstract void BeforeProcessingResolvedNode(Tag tag, YamlNode originalNode, YamlNode resolvedNode);
        public abstract void AfterProcessingResolvedNode(Tag tag, YamlNode originalNode, YamlNode resolvedNode);
    }
}