```
git submodule update --init --recursive
cd godot-cpp
scons platform=<linux/windows/osx> generate_bindings=yes -j4 -bits=64
```
