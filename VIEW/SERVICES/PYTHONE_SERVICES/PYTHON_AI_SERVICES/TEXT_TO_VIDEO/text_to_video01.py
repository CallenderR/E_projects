import sys
import torch
from diffusers import DiffusionPipeline
import imageio
import os

# -------------------------------------------------
# Args from C#
# -------------------------------------------------
prompt = sys.argv[1] if len(sys.argv) > 1 else "A cat playing guitar"
output_path = sys.argv[2] if len(sys.argv) > 2 else "output.mp4"

# -------------------------------------------------
# Device & dtype
# -------------------------------------------------
device = "cuda" if torch.cuda.is_available() else "cpu"
dtype = torch.float16 if device == "cuda" else torch.float32

# -------------------------------------------------
# Load text-to-video model
# (Replace model id with what you actually use)
# -------------------------------------------------
pipe = DiffusionPipeline.from_pretrained(
    "damo-vilab/text-to-video-ms-1.7b",
    torch_dtype=dtype
)
pipe.to(device)

# -------------------------------------------------
# Generate video frames
# -------------------------------------------------
result = pipe(
    prompt,
    num_frames=16,
    height=256,
    width=256,
    num_inference_steps=30
)

frames = result.frames[0]

# ---------------------------------------
