using System;
using System.Collections.Generic;
using System.Linq;

namespace Element.ClientRender.Model
{
    public static class ComponentDocCatalog
    {
        public const string ElementPlusVersion = "2.14";
        public const string ElementBlazorVersion = "2.14.0-alpha.1";

        private static readonly IReadOnlyList<ComponentCategory> categories = new List<ComponentCategory>
        {
            Category("Design", "主题、设计令牌与 Element Plus 变量层。", new[]
            {
                Doc("theme", "Theme", "设计令牌", "Design", "查看 Element Plus 2.14 变量层和基础控件在当前主题下的效果。", "Alpha", "Theme",
                    new[] { Demo("Theme", "DesignTokens.razor", "设计令牌", "使用 ElButton、ElInput 与 ElTable 验证主题变量。") }),
                Doc("configuration", "ElConfigProvider", "配置组件", "Design", "为子组件提供尺寸、命名空间、z-index 与 locale 等级联配置。", "Alpha", "Configuration",
                    new[] { Demo("Configuration", "ConfigProviderDemo.razor", "全局配置", "使用 ElConfigProvider 统一控制子组件默认尺寸与弹层层级。") })
            }),
            Category("X", "AI 场景组件用于会话、提示词、消息气泡、附件、输入和思考过程。", new[]
            {
                Doc("x", "ElX*", "AI 组件", "X", "复刻 Element Plus X 的核心 AI 组件能力，并用 Blazor 组件搭建 ruoyi-element-ai 风格演示。", "Alpha", "X",
                    new[]
                    {
                        Demo("X", "BasicX.razor", "X 组件基础组合", "展示欢迎、提示词、气泡列表和附件卡片。"),
                        Demo("X", "AiWorkspace.razor", "AI 工作台演示", "使用 ElX* 组件组合离线可运行的 ruoyi-element-ai 演示骨架。")
                    })
            }),
            Category("Basic", "基础组件用于组织页面结构与轻量展示。", new[]
            {
                Doc("button", "ElButton", "按钮", "Basic", "常用操作按钮，支持类型、尺寸、禁用、加载和图标。", "Stable", "Button", new[]
                {
                    Demo("Button", "SimpleButton.razor", "基础用法", "使用 ElButton 表达主要、成功、警告等操作。"),
                    Demo("Button", "ButtonGroup.razor", "按钮组", "使用 ElButtonGroup 组织连续操作。"),
                    Demo("Button", "ButtonSizeDemo.razor", "按钮尺寸", "通过 Size 控制按钮尺寸。"),
                    Demo("Button", "DisabledButton.razor", "禁用状态", "通过 Disabled 禁用按钮。"),
                    Demo("Button", "LoadingButton.razor", "加载中", "通过 Loading 表达异步操作。"),
                    Demo("Button", "TextButton.razor", "文字按钮", "使用文本按钮承载轻量操作。"),
                    Demo("Button", "ButtonApi.razor", "扩展能力", "覆盖 link、bg、color、tag 与自定义加载图标。")
                }),
                Doc("border", "Border", "边框", "Basic", "通过 Element Plus 边框、圆角和阴影 token 统一视觉边界。", "Stable", "Border",
                    new[] { Demo("Border", "BasicBorder.razor", "边框令牌", "展示基础边框、圆角、阴影和虚线。") }),
                Doc("color", "Color", "色彩", "Basic", "通过 Element Plus 色彩 token 表达品牌色、状态色和浅深变体。", "Stable", "Color",
                    new[] { Demo("Color", "BasicColor.razor", "色彩令牌", "展示 primary、success、warning、danger、info token。") }),
                Doc("container", "ElContainer", "布局容器", "Basic", "页面级容器五件套，支持 Header、Aside、Main、Footer 组合。", "Stable", "Container", new[]
                {
                    Demo("Container", "BasicContainer.razor", "基础容器"),
                    Demo("Container", "NestedContainer.razor", "嵌套容器")
                }),
                Doc("icon", "ElIcon", "图标", "Basic", "Element 图标字体入口，支持名称、尺寸、颜色和旋转状态。", "Stable", "Icon", new[]
                {
                    Demo("Icon", "BasicIcon.razor", "基础图标"),
                    Demo("Icon", "IconStyle.razor", "图标样式")
                }),
                Doc("layout", "ElLayout", "布局", "Basic", "页面级布局容器，支持上下左右区域组合。", "Stable", "Layout", new[]
                {
                    Demo("Layout", "GridLayout.razor", "栅格布局"),
                    Demo("Layout", "GutterLayout.razor", "分栏间隔"),
                    Demo("Layout", "ResponsiveLayout.razor", "响应式栅格"),
                    Demo("Layout", "BasicLayout.razor", "基础布局"),
                    Demo("Layout", "NestedLayout.razor", "嵌套布局"),
                    Demo("Layout", "Layout.razor", "后台布局")
                }),
                Doc("link", "ElLink", "链接", "Basic", "文本链接，支持类型、禁用、下划线、图标和原生 href。", "Stable", "Link",
                    new[] { Demo("Link", "BasicLink.razor", "基础链接") }),
                Doc("text", "ElText", "文本", "Basic", "轻量文本组件，支持类型、尺寸、标签、单行省略和多行裁剪。", "Stable", "Text", new[]
                {
                    Demo("Text", "BasicText.razor", "基础文本"),
                    Demo("Text", "TextTruncate.razor", "省略文本")
                }),
                Doc("scrollbar", "ElScrollbar", "滚动条", "Basic", "公开滚动容器，支持固定高度、原生滚动条、常显滚动条和滚动方法。", "Stable", "Scrollbar",
                    new[] { Demo("Scrollbar", "BasicScrollbar.razor", "基础滚动条") }),
                Doc("space", "ElSpace", "间距", "Basic", "为一组元素提供稳定的水平或垂直间距。", "Stable", "Space",
                    new[] { Demo("Space", "BasicSpace.razor", "基础间距") }),
                Doc("splitter", "ElSplitter", "分隔面板", "Basic", "通过可拖拽分隔条组织水平或垂直面板。", "Beta", "Splitter", new[]
                {
                    Demo("Splitter", "BasicSplitter.razor", "水平分隔"),
                    Demo("Splitter", "VerticalSplitter.razor", "垂直分隔")
                }),
                Doc("tag", "ElTag", "标签", "Basic", "用于标记状态、类型与可关闭的短文本。", "Stable", "Tag", new[]
                {
                    Demo("Tag", "Basic.razor", "基础标签"),
                    Demo("Tag", "Removeable.razor", "可移除标签"),
                    Demo("Tag", "Size.razor", "标签尺寸"),
                    Demo("Tag", "Theme.razor", "标签主题")
                }),
                Doc("typography", "Typography", "排版", "Basic", "通过字体、字号、行高和文本颜色 token 承接排版规范。", "Stable", "Typography",
                    new[] { Demo("Typography", "BasicTypography.razor", "排版令牌") })
            }),
            Category("Form", "表单组件覆盖输入、选择、校验和文件上传。", new[]
            {
                Doc("input", "ElInput", "输入框", "Form", "基础文本输入，支持绑定、禁用、清除和多尺寸。", "Stable", "Input", new[]
                {
                    Demo("Input", "BasicInput.razor", "基础用法"),
                    Demo("Input", "SizeInput.razor", "输入框尺寸")
                }),
                Doc("radio", "ElRadio", "单选框", "Form", "在一组选项中选择一个值。", "Stable", "Radio", new[]
                {
                    Demo("Radio", "BasicRadio.razor", "基础用法"),
                    Demo("Radio", "BorderedRadio.razor", "有边框"),
                    Demo("Radio", "DisabledRadio.razor", "禁用状态"),
                    Demo("Radio", "DisallowChangeRadio.razor", "拦截变更"),
                    Demo("Radio", "RadioButton.razor", "单选按钮"),
                    Demo("Radio", "RadioGroup.razor", "单选框组")
                }),
                Doc("checkbox", "ElCheckbox", "多选框", "Form", "在一组选项中选择多个值。", "Stable", "CheckBox", new[]
                {
                    Demo("CheckBox", "CheckBoxButtonGroup.razor", "复选按钮组"),
                    Demo("CheckBox", "CheckBoxGroup.razor", "复选框组"),
                    Demo("CheckBox", "HardCode.razor", "硬编码复选框")
                }),
                Doc("select", "ElSelect", "选择器", "Form", "下拉选择器，支持枚举、禁用项和空值。", "Stable", "Select", new[]
                {
                    Demo("Select", "BasicSelect.razor", "基础用法"),
                    Demo("Select", "BindEnum.razor", "绑定枚举"),
                    Demo("Select", "BindNullableEnum.razor", "绑定可空枚举"),
                    Demo("Select", "ItemDisabledSelect.razor", "禁用选项")
                }),
                Doc("switch", "ElSwitch", "开关", "Form", "在两种状态间切换。", "Stable", "Switch", new[]
                {
                    Demo("Switch", "BasicSwitch.razor", "基础用法"),
                    Demo("Switch", "TextSwitch.razor", "文本描述"),
                    Demo("Switch", "DisabledSwitch.razor", "禁用状态")
                }),
                Doc("datepicker", "ElDatePicker", "日期选择器", "Form", "选择日期或日期时间。", "Beta", "DatePicker",
                    new[] { Demo("DatePicker", "BasicPicker.razor", "基础用法") }),
                Doc("form", "ElForm", "表单", "Form", "组织表单项、校验与提交动作。", "Stable", "Form", new[]
                {
                    Demo("Form", "BasicForm.razor", "基础用法"),
                    Demo("Form", "InitilizeForm.razor", "表单初始值"),
                    Demo("Form", "AlignForm.razor", "表单对齐"),
                    Demo("Form", "ValidationForm.razor", "表单校验"),
                    Demo("Form", "HiddenFormItem.razor", "隐藏表单项"),
                    Demo("Form", "InlineForm.razor", "行内表单"),
                    Demo("Form", "AutoGenerateFieldsInitilizeForm.razor", "自动生成表单")
                }),
                Doc("upload", "ElUpload", "文件上传", "Form", "上传文件或图片，并限制大小和类型。", "Beta", "Upload", new[]
                {
                    Demo("Upload", "BasicUpload.razor", "基础上传"),
                    Demo("Upload", "ElUploadLimit.razor", "限制上传"),
                    Demo("Upload", "ImageUpload.razor", "图片上传"),
                    Demo("Upload", "UploadForm.razor", "表单上传")
                }),
                Doc("transfer", "ElTransfer", "穿梭框", "Form", "在两个列表间移动选项。", "Beta", "Transfer", new[]
                {
                    Demo("Transfer", "BasicTransfer.razor", "基础用法"),
                    Demo("Transfer", "FormTransfer.razor", "表单提交")
                })
            }),
            Category("Data", "数据展示组件用于表格、分页和树形结构。", new[]
            {
                Doc("table", "ElTable", "表格", "Data", "展示结构化数据，支持列配置、分页、搜索和操作列。", "Stable", "Table", new[]
                {
                    Demo("Table", "BasicTable.razor", "基础表格"),
                    Demo("Table", "StripeTable.razor", "斑马纹"),
                    Demo("Table", "FixHeaderTable.razor", "固定表头"),
                    Demo("Table", "CheckBoxTable.razor", "复选框表格"),
                    Demo("Table", "CustomColumnTable.razor", "操作列"),
                    Demo("Table", "AutoGenerateColumnTable.razor", "自动生成列"),
                    Demo("Table", "PaginationTable.razor", "分页表格"),
                    Demo("Table", "IgnoreColumnTable.razor", "过滤字段"),
                    Demo("Table", "SearchTable.razor", "搜索表格"),
                    Demo("Table", "CustomTableOrder.razor", "自定义列顺序"),
                    Demo("Table", "UpdatePageSize.razor", "更新分页大小")
                }),
                Doc("pagination", "ElPagination", "分页", "Data", "当数据量较多时进行分页导航。", "Stable", "Pagination", new[]
                {
                    Demo("Pagination", "BasicPagination.razor", "基础用法"),
                    Demo("Pagination", "BackgroundPagination.razor", "背景样式")
                }),
                Doc("tree", "ElTree", "树形控件", "Data", "展示层级结构并支持懒加载。", "Beta", "Tree",
                    new[] { Demo("Tree", "SimpleTree.razor", "基础树") })
            }),
            Category("Navigation", "导航组件用于菜单、标签页和下拉操作。", new[]
            {
                Doc("menu", "ElMenu", "导航菜单", "Navigation", "组织站点导航，支持横向、纵向和自定义配色。", "Stable", "Menu", new[]
                {
                    Demo("Menu", "HorizontalMenu.razor", "横向菜单"),
                    Demo("Menu", "VerticalMenu.razor", "纵向菜单"),
                    Demo("Menu", "CustomBackgroundMenu.razor", "自定义背景")
                }),
                Doc("tabs", "ElTabs", "标签页", "Navigation", "在同一区域切换多个内容面板。", "Stable", "Tab", new[]
                {
                    Demo("Tab", "BasicTab.razor", "基础标签页"),
                    Demo("Tab", "CardTab.razor", "卡片标签页"),
                    Demo("Tab", "BorderCardTab.razor", "边框卡片"),
                    Demo("Tab", "LeftTab.razor", "左侧标签页"),
                    Demo("Tab", "EditableTab.razor", "可编辑标签页"),
                    Demo("Tab", "BindingEditableTab.razor", "双向绑定编辑")
                }),
                Doc("dropdown", "ElDropdown", "下拉菜单", "Navigation", "承载折叠操作集合。", "Stable", "DropDown",
                    new[] { Demo("DropDown", "BasicDropDown.razor", "基础用法") })
            }),
            Category("Feedback", "反馈组件用于加载、消息与弹层。", new[]
            {
                Doc("loading", "ElLoading", "加载", "Feedback", "表达页面、区域或组件的加载状态。", "Stable", "Loading", new[]
                {
                    Demo("Loading", "BasicLoading.razor", "区域加载"),
                    Demo("Loading", "CustomLoading.razor", "自定义加载"),
                    Demo("Loading", "ServiceLoading.razor", "服务调用"),
                    Demo("Loading", "ManualLoading.razor", "手动加载"),
                    Demo("Loading", "CardLoading.razor", "卡片加载"),
                    Demo("Loading", "MenuLoading.razor", "菜单加载")
                }),
                Doc("message", "ElMessage", "消息提示", "Feedback", "轻量级全局消息反馈。", "Stable", "Message", new[]
                {
                    Demo("Message", "BasicMessage.razor", "基础消息"),
                    Demo("Message", "StatusMessage.razor", "不同状态"),
                    Demo("Message", "MultiMessage.razor", "多条消息")
                }),
                Doc("messagebox", "ElMessageBox", "消息弹窗", "Feedback", "用于确认、警告和阻断式反馈。", "Stable", "MessageBox", new[]
                {
                    Demo("MessageBox", "BasicMessageBox.razor", "基础用法"),
                    Demo("MessageBox", "ConfirmMessageBox.razor", "确认消息")
                }),
                Doc("dialog", "ElDialog", "对话框", "Feedback", "在当前页面打开独立任务或详情视图。", "Stable", "Dialog", new[]
                {
                    Demo("Dialog", "BasicDialog.razor", "基础用法"),
                    Demo("Dialog", "NestDialog.razor", "嵌套弹窗"),
                    Demo("Dialog", "PassParameter.razor", "传递参数"),
                    Demo("Dialog", "ExampleDialog.razor", "组合调用")
                })
            }),
            Category("Rich Text", "Markdown 相关组件用于编辑与展示富文本内容。", new[]
            {
                Doc("markdowneditor", "ElMarkdownEditor", "Markdown 编辑器", "Rich Text", "编辑、预览和展示 Markdown 内容。", "Beta", "MarkdownEditor", new[]
                {
                    Demo("MarkdownEditor", "BasicEditor.razor", "基础编辑器"),
                    Demo("MarkdownEditor", "FormMarkdown.razor", "表单提交"),
                    Demo("MarkdownEditor", "Markdown.razor", "Markdown 展示")
                })
            })
        };

        private static readonly IReadOnlyList<ComponentDoc> components = categories.SelectMany(x => x.Components).ToList();

        public static IReadOnlyList<ComponentCategory> Categories => categories;
        public static IReadOnlyList<ComponentDoc> Components => components;

        public static ComponentDoc Find(string slug)
        {
            return components.FirstOrDefault(x => string.Equals(x.Slug, slug, StringComparison.OrdinalIgnoreCase));
        }

        private static ComponentCategory Category(string name, string description, IReadOnlyList<ComponentDoc> components)
        {
            return new ComponentCategory
            {
                Name = name,
                Description = description,
                Components = components
            };
        }

        private static ComponentDoc Doc(
            string slug,
            string componentName,
            string title,
            string category,
            string summary,
            string status,
            string apiKey,
            IReadOnlyList<DemoInfoModel> demos)
        {
            return new ComponentDoc
            {
                Slug = slug,
                ComponentName = componentName,
                Title = title,
                Category = category,
                Summary = summary,
                Status = status,
                Demos = demos,
                Api = ApiRows(apiKey, componentName)
            };
        }

        private static DemoInfoModel Demo(string folder, string file, string title, string description = null, string code = null)
        {
            return new DemoInfoModel
            {
                Name = folder,
                Title = title,
                Description = description ?? string.Empty,
                Files = new List<string> { file },
                Code = code ?? Snippet(folder)
            };
        }

        private static IReadOnlyList<ApiRow> ApiRows(string apiKey, string componentName)
        {
            var rows = new List<ApiRow>();
            switch (apiKey)
            {
                case "Button":
                    rows.Add(Row("Type", "按钮类型。", "ButtonType", "Default"));
                    rows.Add(Row("Size", "按钮尺寸。", "ButtonSize", "Default"));
                    rows.Add(Row("Disabled", "是否禁用。", "bool", "false"));
                    rows.Add(Row("Loading", "是否显示加载状态。", "bool", "false"));
                    rows.Add(Row("Link", "是否渲染为链接样式按钮。", "bool", "false"));
                    rows.Add(Row("Text", "是否渲染为文字按钮。", "bool", "false"));
                    rows.Add(Row("Color", "自定义按钮主题色。", "string", "-"));
                    rows.Add(Row("Tag", "渲染使用的 HTML 标签。", "string", "button"));
                    break;
                case "Border":
                    rows.Add(Row("--el-border", "基础边框 token。", "CSS variable", "1px solid #dcdfe6"));
                    rows.Add(Row("--el-border-radius-base", "基础圆角 token。", "CSS variable", "4px"));
                    rows.Add(Row("--el-box-shadow-light", "轻量阴影 token。", "CSS variable", "-"));
                    break;
                case "Color":
                    rows.Add(Row("--el-color-primary", "品牌主色。", "CSS variable", "#409eff"));
                    rows.Add(Row("--el-color-success", "成功色。", "CSS variable", "#67c23a"));
                    rows.Add(Row("--el-color-warning", "警告色。", "CSS variable", "#e6a23c"));
                    rows.Add(Row("--el-color-danger", "危险色。", "CSS variable", "#f56c6c"));
                    break;
                case "Container":
                    rows.Add(Row("Direction", "子元素排列方向，Auto 会根据 Header/Footer 自动转为纵向。", "ContainerDirection", "Auto"));
                    rows.Add(Row("Height", "Header/Footer 高度。", "string", "60px"));
                    rows.Add(Row("Width", "Aside 宽度。", "string", "300px"));
                    break;
                case "Icon":
                    rows.Add(Row("Name", "图标名称，可省略 el-icon- 前缀。", "string", "-"));
                    rows.Add(Row("Size", "图标大小。", "string", "-"));
                    rows.Add(Row("Color", "图标颜色。", "string", "-"));
                    rows.Add(Row("Spin", "是否旋转。", "bool", "false"));
                    break;
                case "Layout":
                    rows.Add(Row("Gutter", "栅格间隔。", "int", "0"));
                    rows.Add(Row("Span", "栅格占据列数，最大 24。", "int", "24"));
                    rows.Add(Row("Offset", "栅格左侧间隔列数。", "int", "0"));
                    rows.Add(Row("Xs/Sm/Md/Lg/Xl", "响应式栅格列数。", "int?", "-"));
                    break;
                case "Link":
                    rows.Add(Row("Type", "链接类型。", "LinkType", "Default"));
                    rows.Add(Row("Disabled", "是否禁用。", "bool", "false"));
                    rows.Add(Row("Underline", "悬停时是否显示下划线。", "bool", "true"));
                    rows.Add(Row("Href", "原生链接地址。", "string", "-"));
                    rows.Add(Row("Icon", "图标 CSS 类。", "string", "-"));
                    break;
                case "Text":
                    rows.Add(Row("Type", "文本类型。", "TextType", "Default"));
                    rows.Add(Row("Size", "文本尺寸。", "TextSize", "Default"));
                    rows.Add(Row("Tag", "渲染标签。", "string", "span"));
                    rows.Add(Row("Truncated", "是否单行省略。", "bool", "false"));
                    rows.Add(Row("LineClamp", "多行裁剪行数。", "int?", "-"));
                    break;
                case "Scrollbar":
                    rows.Add(Row("Height", "滚动区域高度。", "string", "-"));
                    rows.Add(Row("MaxHeight", "滚动区域最大高度。", "string", "-"));
                    rows.Add(Row("Native", "是否使用原生滚动条。", "bool", "false"));
                    rows.Add(Row("Always", "是否始终显示滚动条。", "bool", "false"));
                    break;
                case "Space":
                    rows.Add(Row("Direction", "排列方向。", "SpaceDirection", "Horizontal"));
                    rows.Add(Row("Alignment", "对齐方式。", "SpaceAlignment", "Center"));
                    rows.Add(Row("Size", "预设间距。", "SpaceSize", "Default"));
                    rows.Add(Row("Spacer", "自定义像素间距。", "int?", "-"));
                    rows.Add(Row("Wrap", "是否换行。", "bool", "false"));
                    break;
                case "Splitter":
                    rows.Add(Row("Direction", "分隔方向。", "SplitterDirection", "Horizontal"));
                    rows.Add(Row("Size", "面板初始尺寸。", "string", "-"));
                    rows.Add(Row("Min", "面板最小尺寸。", "string", "-"));
                    rows.Add(Row("Max", "面板最大尺寸。", "string", "-"));
                    rows.Add(Row("Resizable", "面板之后是否显示拖拽分隔条。", "bool", "true"));
                    break;
                case "Typography":
                    rows.Add(Row("--el-font-family", "全局字体族 token。", "CSS variable", "-"));
                    rows.Add(Row("--el-font-size-base", "基础字号 token。", "CSS variable", "14px"));
                    rows.Add(Row("--el-font-line-height-primary", "主行高 token。", "CSS variable", "24px"));
                    rows.Add(Row("--el-text-color-primary", "主文本颜色 token。", "CSS variable", "#303133"));
                    break;
                case "Configuration":
                    rows.Add(Row("Size", "子组件默认尺寸。", "ElementSize?", "-"));
                    rows.Add(Row("Namespace", "Element CSS 命名空间，默认保留 el。", "string", "el"));
                    rows.Add(Row("ZIndex", "弹层 z-index 基线。", "int?", "2000"));
                    rows.Add(Row("Locale", "当前语言标识。", "string", "CurrentUICulture"));
                    rows.Add(Row("Config", "可复用配置对象。", "ElementConfig", "-"));
                    break;
                case "Input":
                    rows.Add(Row("Value", "绑定值。", "string", "-"));
                    rows.Add(Row("Placeholder", "输入占位文本。", "string", "-"));
                    rows.Add(Row("Clearable", "是否可清空。", "bool", "false"));
                    rows.Add(Row("Disabled", "是否禁用。", "bool", "false"));
                    break;
                case "Table":
                    rows.Add(Row("DataSource", "表格数据源。", "IEnumerable<T>", "-"));
                    rows.Add(Row("AutoGenerateColumns", "是否自动生成列。", "bool", "true"));
                    rows.Add(Row("Border", "是否显示边框。", "bool", "false"));
                    rows.Add(Row("Stripe", "是否显示斑马纹。", "bool", "false"));
                    break;
                case "Form":
                    rows.Add(Row("Model", "表单数据模型。", "object", "-"));
                    rows.Add(Row("Inline", "是否启用行内表单。", "bool", "false"));
                    rows.Add(Row("LabelPosition", "标签位置。", "LabelAlign", "Right"));
                    rows.Add(Row("ChildContent", "表单项内容。", "RenderFragment", "-"));
                    break;
                case "Upload":
                    rows.Add(Row("Url", "上传接口地址。", "string", "-"));
                    rows.Add(Row("UploadType", "上传展示类型。", "UploadType", "File"));
                    rows.Add(Row("MaxSize", "文件大小限制。", "long?", "-"));
                    rows.Add(Row("AllowExtensions", "允许的文件扩展名。", "string[]", "-"));
                    break;
                case "X":
                    rows.Add(Row("ElXBubbleList.Items", "消息列表数据源。", "IEnumerable<XMessageItem>", "-"));
                    rows.Add(Row("ElXConversations.Items", "会话列表数据源。", "IEnumerable<XConversationItem>", "-"));
                    rows.Add(Row("ElXPrompts.Items", "提示词列表数据源。", "IEnumerable<XPromptItem>", "-"));
                    rows.Add(Row("ElXSender.Value", "输入框内容，支持双向绑定。", "string", "-"));
                    rows.Add(Row("ElXSender.OnSubmit", "发送消息事件。", "EventCallback<string>", "-"));
                    rows.Add(Row("ElXThoughtChain.Items", "思考链节点。", "IEnumerable<XThoughtItem>", "-"));
                    break;
                default:
                    rows.Add(Row("ChildContent", "组件内容或插槽内容。", "RenderFragment", "-"));
                    rows.Add(Row("Style", "自定义内联样式。", "string", "-"));
                    rows.Add(Row("Class", "自定义 CSS 类名。", "string", "-"));
                    break;
            }

            rows.Add(Row("Component", "文档中统一使用的控件名。", "string", componentName));
            return rows;
        }

        private static ApiRow Row(string name, string description, string type, string defaultValue)
        {
            return new ApiRow
            {
                Name = name,
                Description = description,
                Type = type,
                DefaultValue = defaultValue
            };
        }

        private static string Snippet(string folder)
        {
            switch (folder)
            {
                case "Theme":
                    return @"<ElButton Type=""@ButtonType.Primary"">Primary</ElButton>
<ElInput TValue=""string"" Placeholder=""Tokenized input""></ElInput>";
                case "Configuration":
                    return @"<ElConfigProvider Size=""@ElementSize.Large"" ZIndex=""3500"" Locale=""en-US"">
    <ElButton Type=""@ButtonType.Primary"">Large from provider</ElButton>
    <ElInput TValue=""string"" Placeholder=""Large input""></ElInput>
</ElConfigProvider>";
                case "X":
                    return @"<ElXWelcome Title=""Element-Blazor X"" Description=""AI scene components"" />
<ElXBubbleList Items=""@messages"" />
<ElXSender @bind-Value=""draft"" OnSubmit=""SendAsync"" />";
                case "Button":
                    return @"<ElButton>Default</ElButton>
<ElButton Type=""@ButtonType.Primary"">Primary</ElButton>
<ElButton Type=""@ButtonType.Success"" Plain=""true"">Success</ElButton>";
                case "Border":
                    return @"<div style=""border: var(--el-border); border-radius: var(--el-border-radius-base);"">Border token</div>";
                case "Color":
                    return @"<div style=""background: var(--el-color-primary); color: var(--el-color-white);"">Primary</div>";
                case "Container":
                    return @"<ElContainer>
    <ElHeader>Header</ElHeader>
    <ElMain>Main</ElMain>
</ElContainer>";
                case "Icon":
                    return @"<ElIcon Name=""edit"" Size=""20""></ElIcon>
<ElIcon Name=""loading"" Spin=""true""></ElIcon>";
                case "Layout":
                    return @"<ElRow Gutter=""16"">
    <ElCol Span=""12"">A</ElCol>
    <ElCol Span=""12"">B</ElCol>
</ElRow>";
                case "Link":
                    return @"<ElLink Type=""@LinkType.Primary"" Href=""https://element-plus.org"">Element Plus</ElLink>";
                case "Text":
                    return @"<ElText Type=""@TextType.Primary"" Truncated=""true"">Primary text</ElText>";
                case "Scrollbar":
                    return @"<ElScrollbar Height=""200px"">
    <div>Scrollable content</div>
</ElScrollbar>";
                case "Space":
                    return @"<ElSpace Wrap=""true"">
    <ElButton>One</ElButton>
    <ElButton>Two</ElButton>
</ElSpace>";
                case "Splitter":
                    return @"<ElSplitter>
    <ElSplitterPanel Size=""200px"">Left</ElSplitterPanel>
    <ElSplitterPanel>Right</ElSplitterPanel>
</ElSplitter>";
                case "Tag":
                    return @"<ElTag Type=""TagType.Success"">Success</ElTag>
<ElTag Type=""TagType.Warning"" Closable=""true"">Warning</ElTag>";
                case "Typography":
                    return @"<ElText Size=""@TextSize.Large"">Typography token text</ElText>";
                case "Input":
                    return @"<ElInput TValue=""string"" Placeholder=""Please input""></ElInput>
<ElInput TValue=""string"" Clearable=""true""></ElInput>";
                case "Radio":
                    return @"<ElRadioGroup @bind-SelectedValue=""selectedValue"">
    <ElRadio TValue=""object"" Model=""1"">Option A</ElRadio>
    <ElRadio TValue=""object"" Model=""2"">Option B</ElRadio>
</ElRadioGroup>";
                case "CheckBox":
                    return @"<ElCheckboxGroup TValue=""List<int>"">
    <ElCheckbox TValue=""object"" Model=""1"">Option A</ElCheckbox>
    <ElCheckbox TValue=""object"" Model=""2"">Option B</ElCheckbox>
</ElCheckboxGroup>";
                case "Select":
                    return @"<ElSelect TValue=""string"" Placeholder=""Select"">
    <ElOption Value=""A"" Label=""Option A""></ElOption>
    <ElOption Value=""B"" Label=""Option B""></ElOption>
</ElSelect>";
                case "Switch":
                    return @"<ElSwitch TValue=""bool"" ActiveValue=""true"" InactiveValue=""false""></ElSwitch>";
                case "DatePicker":
                    return @"<ElDatePicker></ElDatePicker>";
                case "Form":
                    return @"<ElForm Model=""model"">
    <ElFormItem TValue=""string"" Label=""Name"" Prop=""Name"" Required=""true"">
        <ElInput TValue=""string""></ElInput>
    </ElFormItem>
</ElForm>";
                case "Upload":
                    return @"<ElUpload Url=""/api/upload""></ElUpload>";
                case "Transfer":
                    return @"<ElTransfer List1=""sourceItems"" List2=""targetItems""></ElTransfer>";
                case "Table":
                    return @"<ElTable DataSource=""Rows"" AutoGenerateColumns=""false"">
    <ElTableColumns>
        <ElTableColumn Property=""Name"" Text=""Name""></ElTableColumn>
    </ElTableColumns>
</ElTable>";
                case "Pagination":
                    return @"<ElPagination Total=""600""></ElPagination>";
                case "Tree":
                    return @"<ElTree>
    <ElTreeItem Id=""1"" Text=""Root"">
        <ElTreeItem Id=""2"" Text=""Child""></ElTreeItem>
    </ElTreeItem>
</ElTree>";
                case "Menu":
                    return @"<ElMenu Mode=""@MenuMode.Vertical"" DefaultActive=""button"">
    <ElMenuItem Route=""button"">Button</ElMenuItem>
    <ElMenuItem Route=""input"">Input</ElMenuItem>
</ElMenu>";
                case "Tab":
                    return @"<ElTabs>
    <ElTabPane Title=""User"">User panel</ElTabPane>
    <ElTabPane Title=""Role"">Role panel</ElTabPane>
</ElTabs>";
                case "DropDown":
                    return @"<ElDropdown>
    <Trigger>
        <ElButton>Actions</ElButton>
    </Trigger>
    <Items>
        <ElDropdownItem>Edit</ElDropdownItem>
    </Items>
</ElDropdown>";
                case "Loading":
                    return @"<ElLoading>
    <ElTable DataSource=""Rows""></ElTable>
</ElLoading>";
                case "Message":
                    return @"<ElButton OnClick=""ShowMessage"">Show message</ElButton>";
                case "MessageBox":
                    return @"<ElButton OnClick=""ShowMessageBox"">Show message box</ElButton>";
                case "Dialog":
                    return @"<ElButton OnClick=""ShowDialog"">Open dialog</ElButton>
<ElDialog Title=""Dialog""></ElDialog>";
                case "MarkdownEditor":
                    return @"<ElMarkdownEditor @bind-Value=""content""></ElMarkdownEditor>";
                default:
                    return @"<ElButton Type=""@ButtonType.Primary"">Example</ElButton>";
            }
        }
    }
}
