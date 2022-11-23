Set fileName=maplinktest
Set destPath=..\PythonGrpcClient
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%

Set fileName=morai_openscenario_base
Set destPath=..\PythonGrpcClient
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%

Set fileName=morai_openscenario_msgs
Set destPath=..\PythonGrpcClient
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%

Set fileName=moraibridge
Set destPath=..\PythonGrpcClient
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%

Set fileName=geometry_msgs
Set destPath=..\PythonGrpcClient
python -m grpc_tools.protoc -I./ --python_out=. --grpc_python_out=. ./%fileName%.proto
Set sourceFile=%fileName%_pb2.py
move %sourceFile% %destPath%
Set sourceFile=%fileName%_pb2_grpc.py
move %sourceFile% %destPath%