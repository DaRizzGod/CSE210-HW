using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class GoalConverter : JsonConverter<Goal>
{
    public override Goal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument doc = JsonDocument.ParseValue(ref reader))
        {
            JsonElement root = doc.RootElement;
            string type = root.GetProperty("Type").GetString();
            string json = root.GetRawText();

            return type switch
            {
                nameof(SimpleGoal) => JsonSerializer.Deserialize<SimpleGoal>(json, options),
                nameof(EternalGoal) => JsonSerializer.Deserialize<EternalGoal>(json, options),
                nameof(ChecklistGoal) => JsonSerializer.Deserialize<ChecklistGoal>(json, options),
                _ => throw new NotSupportedException($"Unsupported goal type: {type}")
            };
        }
    }

    public override void Write(Utf8JsonWriter writer, Goal value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();
        writer.WriteString("Type", value.GetType().Name);

        foreach (var property in value.GetType().GetProperties())
        {
            if (property.CanRead)
            {
                writer.WritePropertyName(property.Name);
                JsonSerializer.Serialize(writer, property.GetValue(value), property.PropertyType, options);
            }
        }
        
        writer.WriteEndObject();
    }
}


