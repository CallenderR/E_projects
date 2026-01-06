import sys
import torch
from diffusers import ZVisionPipeline
from PIL import Image

# -------------------------------------------------
# Device & dtype
# -------------------------------------------------
device = "cuda" if torch.cuda.is_available() else "cpu"
dtype = torch.bfloat16 if device == "cuda" else torch.float32

# -------------------------------------------------
# Load image-to-text model
# -------------------------------------------------
model_path = r"C:\PROJECTS\E_APP02\E_APP02\FILES\EXTERNAL_FILES\GUFF_FILES\MiMo-VL-7B-RL-IQ4_NL.gguf"
pipe = ZVisionPipeline.from_single_file(model_path, torch_dtype=dtype)
pipe.to(device)

# -------------------------------------------------
# Get image path from C#
# -------------------------------------------------
image_path = sys.argv[1] if len(sys.argv) > 1 else "test.png"

# -------------------------------------------------
# Load image
# -------------------------------------------------
image = Image.open(image_path).convert("RGB")

# -------------------------------------------------
# Run model
# -------------------------------------------------
text_output = pipe(image, max_new_tokens=128)

# -------------------------------------------------
# Return the recognized text
# -------------------------------------------------
print(text_output["text"])
