using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace AlloyTraining.Models.Media
{
    [ContentType(DisplayName = "Any File", GUID = "fe27de26-bce0-4468-be41-50e83598325c", Description = "Use this to upload any type of file.")]
    public class AnyFile : MediaData
    {
    }
}