import torch
import sys
from diffusers import ZImagePipeline
from io import BytesIO
import base64

# -------------------------------------------------
# Device & dtype
# -------------------------------------------------
device = "cuda" if torch.cuda.is_available() else "cpu"
dtype = torch.float16 if device == "cuda" else torch.float32

# -------------------------------------------------
# Load model
# -------------------------------------------------
pipe = ZImagePipeline.from_pretrained(
    "Tongyi-MAI/Z-Image-Turbo",
    torch_dtype=dtype
).to(device)

# -------------------------------------------------
# Get prompt from C#
# -------------------------------------------------
prompt = sys.argv[1] if len(sys.argv) > 1 else "The coolest robot ever, ultra detailed"

# -------------------------------------------------
# Generate image
# -------------------------------------------------
image = pipe(
    prompt=prompt,
    height=768,
    width=768,
    guidance_scale=5.0,
    num_inference_steps=25
).images[0]

# -------------------------------------------------
# Convert image to Base64
# -------------------------------------------------
buffer = BytesIO()
image.save(buffer, format="PNG")
encoded = base64.b64encode(buffer.getvalue()).decode()

# -------------------------------------------------
# Return Base64 string
# -------------------------------------------------
print(encoded)
