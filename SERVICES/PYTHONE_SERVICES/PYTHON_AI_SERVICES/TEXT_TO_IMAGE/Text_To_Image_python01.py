import torch
import sys
import os
from diffusers import StableDiffusionXLPipeline

device = "cuda" if torch.cuda.is_available() else "cpu"
dtype = torch.float16 if device == "cuda" else torch.float32

MODEL_PATH = r"C:\PROJECTS\E_APP02\E_APP02\FILES\EXTERNAL_FILES\SAFETENSORS\SAFETENSORS_FILES\sdxl_base"

pipe = StableDiffusionXLPipeline.from_pretrained(
    MODEL_PATH,
    torch_dtype=dtype,
    local_files_only=True
).to(device)

prompt = sys.argv[1]

image = pipe(
    prompt=prompt,
    guidance_scale=7.5,
    num_inference_steps=30,
    height=1024,
    width=1024
).images[0]

output_path = os.path.abspath("sdxl_output.png")
image.save(output_path)

print(f"SUCCESS:{output_path}")