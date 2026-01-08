import sys
import json
import torch
from diffusers import DiffusionPipeline
import uuid
import os

MODEL_ID = "Qwen/Qwen-Image-2512"
OUTPUT_DIR = "outputs"
os.makedirs(OUTPUT_DIR, exist_ok=True)

# Read JSON from stdin
request = json.loads(sys.stdin.read())

prompt = request["prompt"]
steps = request.get("steps", 30)
width = request.get("width", 1024)
height = request.get("height", 1024)
seed = request.get("seed")

pipe = DiffusionPipeline.from_pretrained(
    MODEL_ID,
    torch_dtype=torch.float16
).to("cuda")

generator = None
if seed is not None:
    generator = torch.Generator("cuda").manual_seed(seed)

image = pipe(
    prompt=prompt,
    num_inference_steps=steps,
    width=width,
    height=height,
    generator=generator
).images[0]

filename = f"{uuid.uuid4()}.png"
path = os.path.join(OUTPUT_DIR, filename)
image.save(path)

# Output JSON to stdout
print(json.dumps({
    "filename": filename,
    "path": path
}))
