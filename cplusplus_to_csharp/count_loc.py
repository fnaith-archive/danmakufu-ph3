import os

def count_lines(root_paths, file_extension):
  line_number = 0
  root_dir = os.path.join(os.path.dirname(os.path.abspath(__file__)), *root_paths)
  for dir_path, dir_names, file_names in os.walk(root_dir):
    for file_name in [fn for fn in file_names if fn.endswith(file_extension)]:
      with open(os.path.join(dir_path, file_name), errors='ignore') as f:
        line_number += f.read().count('\n')
  return line_number

GcLib_gstd = count_lines(['source', 'GcLib', 'gstd'], '.cs')
GcLib_directx = count_lines(['source', 'GcLib', 'directx'], '.cs')
GcLib_ext = count_lines(['source', 'GcLib', 'ext'], '.cs')
TouhouDanmakufu_Common = count_lines(['source', 'TouhouDanmakufu', 'Common'], '.cs')
TouhouDanmakufu_DnhConfig = count_lines(['source', 'TouhouDanmakufu', 'DnhConfig'], '.cs')
TouhouDanmakufu_DnhExecutor = count_lines(['source', 'TouhouDanmakufu', 'DnhExecutor'], '.cs')
TouhouDanmakufu_DnhViewer = count_lines(['source', 'TouhouDanmakufu', 'DnhViewer'], '.cs')

print('GcLib : %d lines' % (GcLib_gstd + GcLib_directx + GcLib_ext))
print('GcLib_gstd : %d lines' % GcLib_gstd)
print('GcLib_directx : %d lines' % GcLib_directx)
print('GcLib_ext : %d lines' % GcLib_ext)
print('TouhouDanmakufu : %d lines' % (TouhouDanmakufu_Common + TouhouDanmakufu_DnhConfig + TouhouDanmakufu_DnhExecutor + TouhouDanmakufu_DnhViewer))
print('TouhouDanmakufu_Common : %d lines' % TouhouDanmakufu_Common)
print('TouhouDanmakufu_DnhConfig : %d lines' % TouhouDanmakufu_DnhConfig)
print('TouhouDanmakufu_DnhExecutor : %d lines' % TouhouDanmakufu_DnhExecutor)
print('TouhouDanmakufu_DnhViewer : %d lines' % TouhouDanmakufu_DnhViewer)
