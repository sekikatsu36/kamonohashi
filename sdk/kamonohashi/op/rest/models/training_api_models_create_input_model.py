# coding: utf-8

"""
    KAMONOHASHI API

    A platform for deep learning  # noqa: E501

    OpenAPI spec version: v1
    Contact: kamonohashi-support@jp.nssol.nipponsteel.com
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""


import pprint
import re  # noqa: F401

import six

from kamonohashi.op.rest.models.components_container_image_input_model import ComponentsContainerImageInputModel  # noqa: F401,E501
from kamonohashi.op.rest.models.components_git_commit_input_model import ComponentsGitCommitInputModel  # noqa: F401,E501


class TrainingApiModelsCreateInputModel(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """

    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'container_image': 'ComponentsContainerImageInputModel',
        'cpu': 'int',
        'data_set_id': 'int',
        'entry_point': 'str',
        'git_model': 'ComponentsGitCommitInputModel',
        'gpu': 'int',
        'memo': 'str',
        'memory': 'int',
        'name': 'str',
        'options': 'dict(str, str)',
        'parent_id': 'int',
        'partition': 'str'
    }

    attribute_map = {
        'container_image': 'containerImage',
        'cpu': 'cpu',
        'data_set_id': 'dataSetId',
        'entry_point': 'entryPoint',
        'git_model': 'gitModel',
        'gpu': 'gpu',
        'memo': 'memo',
        'memory': 'memory',
        'name': 'name',
        'options': 'options',
        'parent_id': 'parentId',
        'partition': 'partition'
    }

    def __init__(self, container_image=None, cpu=None, data_set_id=None, entry_point=None, git_model=None, gpu=None, memo=None, memory=None, name=None, options=None, parent_id=None, partition=None):  # noqa: E501
        """TrainingApiModelsCreateInputModel - a model defined in Swagger"""  # noqa: E501

        self._container_image = None
        self._cpu = None
        self._data_set_id = None
        self._entry_point = None
        self._git_model = None
        self._gpu = None
        self._memo = None
        self._memory = None
        self._name = None
        self._options = None
        self._parent_id = None
        self._partition = None
        self.discriminator = None

        self.container_image = container_image
        self.cpu = cpu
        self.data_set_id = data_set_id
        self.entry_point = entry_point
        self.git_model = git_model
        self.gpu = gpu
        if memo is not None:
            self.memo = memo
        self.memory = memory
        self.name = name
        if options is not None:
            self.options = options
        if parent_id is not None:
            self.parent_id = parent_id
        if partition is not None:
            self.partition = partition

    @property
    def container_image(self):
        """Gets the container_image of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The container_image of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: ComponentsContainerImageInputModel
        """
        return self._container_image

    @container_image.setter
    def container_image(self, container_image):
        """Sets the container_image of this TrainingApiModelsCreateInputModel.


        :param container_image: The container_image of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: ComponentsContainerImageInputModel
        """
        if container_image is None:
            raise ValueError("Invalid value for `container_image`, must not be `None`")  # noqa: E501

        self._container_image = container_image

    @property
    def cpu(self):
        """Gets the cpu of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The cpu of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: int
        """
        return self._cpu

    @cpu.setter
    def cpu(self, cpu):
        """Sets the cpu of this TrainingApiModelsCreateInputModel.


        :param cpu: The cpu of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: int
        """
        if cpu is None:
            raise ValueError("Invalid value for `cpu`, must not be `None`")  # noqa: E501

        self._cpu = cpu

    @property
    def data_set_id(self):
        """Gets the data_set_id of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The data_set_id of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: int
        """
        return self._data_set_id

    @data_set_id.setter
    def data_set_id(self, data_set_id):
        """Sets the data_set_id of this TrainingApiModelsCreateInputModel.


        :param data_set_id: The data_set_id of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: int
        """
        if data_set_id is None:
            raise ValueError("Invalid value for `data_set_id`, must not be `None`")  # noqa: E501

        self._data_set_id = data_set_id

    @property
    def entry_point(self):
        """Gets the entry_point of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The entry_point of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: str
        """
        return self._entry_point

    @entry_point.setter
    def entry_point(self, entry_point):
        """Sets the entry_point of this TrainingApiModelsCreateInputModel.


        :param entry_point: The entry_point of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: str
        """
        if entry_point is None:
            raise ValueError("Invalid value for `entry_point`, must not be `None`")  # noqa: E501

        self._entry_point = entry_point

    @property
    def git_model(self):
        """Gets the git_model of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The git_model of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: ComponentsGitCommitInputModel
        """
        return self._git_model

    @git_model.setter
    def git_model(self, git_model):
        """Sets the git_model of this TrainingApiModelsCreateInputModel.


        :param git_model: The git_model of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: ComponentsGitCommitInputModel
        """
        if git_model is None:
            raise ValueError("Invalid value for `git_model`, must not be `None`")  # noqa: E501

        self._git_model = git_model

    @property
    def gpu(self):
        """Gets the gpu of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The gpu of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: int
        """
        return self._gpu

    @gpu.setter
    def gpu(self, gpu):
        """Sets the gpu of this TrainingApiModelsCreateInputModel.


        :param gpu: The gpu of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: int
        """
        if gpu is None:
            raise ValueError("Invalid value for `gpu`, must not be `None`")  # noqa: E501

        self._gpu = gpu

    @property
    def memo(self):
        """Gets the memo of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The memo of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: str
        """
        return self._memo

    @memo.setter
    def memo(self, memo):
        """Sets the memo of this TrainingApiModelsCreateInputModel.


        :param memo: The memo of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: str
        """

        self._memo = memo

    @property
    def memory(self):
        """Gets the memory of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The memory of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: int
        """
        return self._memory

    @memory.setter
    def memory(self, memory):
        """Sets the memory of this TrainingApiModelsCreateInputModel.


        :param memory: The memory of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: int
        """
        if memory is None:
            raise ValueError("Invalid value for `memory`, must not be `None`")  # noqa: E501

        self._memory = memory

    @property
    def name(self):
        """Gets the name of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The name of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this TrainingApiModelsCreateInputModel.


        :param name: The name of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def options(self):
        """Gets the options of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The options of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: dict(str, str)
        """
        return self._options

    @options.setter
    def options(self, options):
        """Sets the options of this TrainingApiModelsCreateInputModel.


        :param options: The options of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: dict(str, str)
        """

        self._options = options

    @property
    def parent_id(self):
        """Gets the parent_id of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The parent_id of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: int
        """
        return self._parent_id

    @parent_id.setter
    def parent_id(self, parent_id):
        """Sets the parent_id of this TrainingApiModelsCreateInputModel.


        :param parent_id: The parent_id of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: int
        """

        self._parent_id = parent_id

    @property
    def partition(self):
        """Gets the partition of this TrainingApiModelsCreateInputModel.  # noqa: E501


        :return: The partition of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :rtype: str
        """
        return self._partition

    @partition.setter
    def partition(self, partition):
        """Sets the partition of this TrainingApiModelsCreateInputModel.


        :param partition: The partition of this TrainingApiModelsCreateInputModel.  # noqa: E501
        :type: str
        """

        self._partition = partition

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(TrainingApiModelsCreateInputModel, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, TrainingApiModelsCreateInputModel):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
