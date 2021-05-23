import os
# TODO
# to refine and add support for two concequent arrays of the same subject. eg Computational_models.js
dir_path = r'<questions/answers direcoty path>'
file_path = r'<js array file full path>'

directory = os.fsencode(dir_path)
arr_name = 'Computational_models=[\n'
start_str = '"'
end_str = '",\n'
images = ''


def writer(array, imagesList):
    str_to_write = array + imagesList + ']'
    f = open(file_path, 'w')
    f.write(str_to_write)
    f.close


file_list = os.listdir(directory)
for file in file_list:
    filename = os.fsdecode(file)
    if filename.endswith(".jpg") or filename.endswith(".jpeg") or filename.endswith(".png") or filename.endswith(".webp"):
        if file == file_list[len(file_list)-1]:
            end_str = '"\n'
        images += start_str + filename + end_str
        continue
    else:
        continue

writer(arr_name, images)
