---
permalink: edmx
---

In a rare occasion, your model might not still compatible yet with our model reader. If that's your case and we ask you for your model, you can use one of the following methods to provide the required information:

## Code First
Use the `GetModelXDocument` method to generate the Edmx to send.


```csharp
public string GetModelXDocument(DbContext context)
{
    XDocument doc;
    using (var memoryStream = new MemoryStream())
    {
        using (XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings { Indent = true }))
        {
            EdmxWriter.WriteEdmx(context, xmlWriter);
        }
 
        memoryStream.Position = 0;
 
        doc = XDocument.Load(memoryStream);
    }
    return doc.ToString();
}

DbContext context = new EntityContext();
string edmx = GetModelXDocument();
```


## Database First
Provide us the [fileName].edmx directly.
