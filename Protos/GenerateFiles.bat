Set fileName=morai
Set destPath=..\proto_py
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%

Set fileName=common
Set destPath=..\proto_py
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%