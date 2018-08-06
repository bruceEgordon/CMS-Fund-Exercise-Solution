using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.Blobs;
using EPiServer.Framework.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Svg File", GUID = "ab005965-ed42-4dbe-bdd2-6e7e881ea343", Description = "Use this to upload Scalable Vector Graphics (SVG) images.")]
    [MediaDescriptor(ExtensionString = "svg")]
    public class SvgFile : ImageData
    {

        [CultureSpecific]
        [Editable(true)]
        public virtual string Description { get; set; }

        public override Blob Thumbnail { get => base.BinaryData; set => base.Thumbnail = value; }

    }
}